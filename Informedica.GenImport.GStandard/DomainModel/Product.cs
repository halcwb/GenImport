using System;
using Informedica.GenImport.GStandard.Attributes;
using Informedica.GenImport.GStandard.DomainModel.Enums;
using Informedica.GenImport.GStandard.DomainModel.Interfaces;

namespace Informedica.GenImport.GStandard.DomainModel
{
    public class Product : Entity<Product>, IProduct
    {
        #region Implementation of IProduct

        /// <summary>
        /// Mutatiekode
        /// </summary>
        [FileLinePosition(5, 5)]
        public virtual MutKod MutKod { get; set; }

        /// <summary>
        /// ZI-nummer
        /// </summary>
        [FileLinePosition(6, 13)]
        [Modulo11]
        public virtual int AtKode
        {
            get { return Id; }
            set { Id = value; }
        }

        /// <summary>
        /// HandelsProduktKode
        /// </summary>
        [FileLinePosition(14, 21)]
        [Modulo11]
        public virtual int HpKode { get; set; }

        /// <summary>
        /// Artikelnaamnummer
        /// </summary>
        [FileLinePosition(22, 28)]
        public virtual int AtNmNr { get; set; }

        #endregion

        #region Overrides of Entity<Product,int>

        public override bool IsIdentical(Product entity)
        {
            return IsIdentical(entity);
        }

        #endregion

        #region Implementation of IEntity<in IProduct,out int>

        public virtual bool IsIdentical(IProduct entity)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Implementation of ICopyable<in IProduct>

        public virtual void CopyTo(IProduct other)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}