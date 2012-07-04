using System;
using Informedica.GenImport.GStandard.Attributes;
using Informedica.GenImport.GStandard.DomainModel.Enums;
using Informedica.GenImport.GStandard.DomainModel.Interfaces;

namespace Informedica.GenImport.GStandard.DomainModel
{
    public class PrescriptieProduct : Entity<PrescriptieProduct>, IPrescriptieProduct
    {
        #region Implementation of IPrescriptieProduct

        /// <summary>
        /// Mutatiekode
        /// </summary>
        [FileLinePosition(5, 5)]
        public virtual MutKod MutKod { get; set; }

        /// <summary>
        /// PRK-code
        /// </summary>
        [FileLinePosition(6, 13)]
        [Modulo11]
        public virtual int PrKode
        {
            get { return Id; }
            set { Id = value; }
        }

        /// <summary>
        /// Naamnummer prescriptie product
        /// </summary>
        [FileLinePosition(14, 20)]
        public virtual int PrNmNr { get; set; }

        #endregion

        #region Overrides of Entity<PrescriptieProduct,int>

        public override bool IsIdentical(PrescriptieProduct entity)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
