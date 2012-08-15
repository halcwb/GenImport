using Informedica.GenImport.GStandard.Attributes;
using Informedica.GenImport.GStandard.DomainModel;
using Informedica.GenImport.GStandard.DomainModel.Enums;
using Informedica.GenImport.GStandard.DomainModel.Equality;
using Informedica.GenImport.GStandard.Tests.Attributes;
using Informedica.GenImport.Library.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Informedica.GenImport.GStandard.Tests.DomainModel
{
    [TestClass]
    public class RelationBetweenNameShould
    {
        #region FileLinePositionAttribute

        [TestMethod]
        public void Have_A_LinePositionAttribute_On_4_Known_Properties()
        {
            const int expectedCount = 4;
            Assert.IsTrue(AttributeTestUtility.HasAttributeCount<RelationBetweenName, FileLinePositionAttribute>(expectedCount));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_MutKod_Property_With_Position_5_5()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new RelationBetweenName().MutKod);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 5, 5),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_NmRNr_Property_With_Position_6_8()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new RelationBetweenName().NmRNr);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 6, 8),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_NmNrIn_Property_With_Position_9_15()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new RelationBetweenName().NmNrIn);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 9, 15),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_NmNrUit_Property_With_Position_16_22()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new RelationBetweenName().NmNrUit);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 16, 22),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        #endregion

        #region IsIdentical

        [TestMethod]
        public void Return_True_On_IsIdentical_When_Identity_Is_Equal()
        {
            var x = new RelationBetweenName
            {
                NmNrIn = 1,
                NmNrUit = 2,
                NmRNr = 3
            };
            var y = new RelationBetweenName
            {
                NmNrIn = 1,
                NmNrUit = 2,
                NmRNr = 3
            };

            Assert.IsTrue(x.IsIdentical(y));
        }

        [TestMethod]
        public void Return_False_On_IsIdentical_When_NmNrIn_Is_Different()
        {
            var x = new RelationBetweenName
            {
                NmNrIn = 1,
                NmNrUit = 2,
                NmRNr = 3
            };
            var y = new RelationBetweenName
            {
                NmNrIn = 2,
                NmNrUit = 2,
                NmRNr = 3
            };

            Assert.IsFalse(x.IsIdentical(y));
        }

        [TestMethod]
        public void Return_False_On_IsIdentical_When_NmNrUit_Is_Different()
        {
            var x = new RelationBetweenName
            {
                NmNrIn = 1,
                NmNrUit = 2,
                NmRNr = 3
            };
            var y = new RelationBetweenName
            {
                NmNrIn = 1,
                NmNrUit = 3,
                NmRNr = 3
            };

            Assert.IsFalse(x.IsIdentical(y));
        }

        [TestMethod]
        public void Return_False_On_IsIdentical_When_NmRNr_Is_Different()
        {
            var x = new RelationBetweenName
            {
                NmNrIn = 1,
                NmNrUit = 2,
                NmRNr = 3
            };
            var y = new RelationBetweenName
            {
                NmNrIn = 1,
                NmNrUit = 2,
                NmRNr = 4
            };

            Assert.IsFalse(x.IsIdentical(y));
        }

        #endregion

        #region CopyTo

        [TestMethod]
        public void Copy_All_Fields_From_One_To_Another()
        {
            var from = new RelationBetweenName
            {
                MutKod = MutKod.RecordUpdated,
                NmNrIn = 1,
                NmNrUit = 2,
                NmRNr = 3
            };
            var to = new RelationBetweenName();

            from.CopyTo(to);

            Assert.IsTrue(new RelationBetweenNameComparer().Equals(from, to));
        }

        #endregion
    }
}
