using System;
using System.Collections.Generic;
using Informedica.EntityRepository.Entities;
using Informedica.GenImport.GStandard.DomainModel;
using Informedica.GenImport.GStandard.DomainModel.Interfaces;
using Informedica.GenImport.GStandard.Mappings;
using Informedica.GenImport.GStandard.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Informedica.GenImport.GStandard.Tests.Repositories
{
    [TestClass]
    public class NHibernateRepositoryShould : TestSessionContext
    {
        #region Helpers

        private class MyEntity : Entity<MyEntity>, ICopyable<MyEntity>
        {
            public virtual string Name { get; set; }

            public virtual int MyId
            {
                set { Id = value; }
            }

            #region Overrides of Entity<MyCopyableEntity,int>

            public override bool IsIdentical(MyEntity entity)
            {
                return entity.Id == Id;
            }

            #endregion

            #region Implementation of ICopyable<in MyEntity>

            public virtual void CopyTo(MyEntity other)
            {
                other.MyId = Id;
                other.Name = Name;
            }

            #endregion
        }

        private class MyEntityMap : EntityMap<MyEntity>
        {
            public MyEntityMap()
            {
                Map(x => x.Name).Length(50);
            }
        }

        private class MyEntityComparer : IEqualityComparer<MyEntity>
        {
            #region Implementation of IEqualityComparer<in MyEntity>

            public bool Equals(MyEntity x, MyEntity y)
            {
                return x.Name == y.Name;
            }

            public int GetHashCode(MyEntity obj)
            {
                return obj.Name.GetHashCode();
            }

            #endregion
        }

        #endregion

        [TestMethod]
        public void Save_A_New_Entity_When_Added()
        {
            var factory = GetSessionFactory(x => x.FluentMappings.Add(typeof(MyEntityMap)));
            var repository = new NHibernateRepository<MyEntity>(factory, new MyEntityComparer());
            var entity = new MyEntity { Name = "Name", MyId = 1 };
            repository.Add(entity);

            var dbEntity = repository.GetById(1);
            Assert.IsNotNull(dbEntity);
        }

        [TestMethod]
        public void Update_An_Existing_Entity_When_Added()
        {
            var factory = GetSessionFactory(x => x.FluentMappings.Add(typeof(MyEntityMap)));
            var repository = new NHibernateRepository<MyEntity>(factory, new MyEntityComparer());
            var entity1 = new MyEntity { Name = "Name", MyId = 1 };
            var entity2 = new MyEntity { Name = "Updated", MyId = 1 };
            repository.Add(entity1);
            repository.Add(entity2);

            var dbEntity = repository.GetById(1);
            Assert.AreEqual("Updated", dbEntity.Name);
        }

        [TestMethod]
        public void Skip_An_Entity_When_It_Already_Exists()
        {
            var factory = GetSessionFactory(x => x.FluentMappings.Add(typeof(MyEntityMap)));
            var repository = new NHibernateRepository<MyEntity>(factory, new MyEntityComparer());
            var entity1 = new MyEntity { Name = "Name", MyId = 1 };
            var entity2 = new MyEntity { Name = "Name", MyId = 1 };
            repository.Add(entity1);
            repository.Add(entity2);

            var dbEntity = repository.GetById(1);
            Assert.AreEqual(entity1, dbEntity);
            Assert.AreNotEqual(entity2, dbEntity);
        }

        [TestMethod]
        public void Add_Entities()
        {
            const int expectedCount = 2;
            var factory = GetSessionFactory(x => x.FluentMappings.Add(typeof(MyEntityMap)));
            var repository = new NHibernateRepository<MyEntity>(factory, new MyEntityComparer());

            var entities = new List<MyEntity>{
                                                 new MyEntity{Name = "Name1", MyId = 1},
                                                 new MyEntity{Name = "Name2", MyId = 2}
                                             };
            repository.Add(entities);

            Assert.AreEqual(expectedCount, repository.Count);
        }
    }
}
