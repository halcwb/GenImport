using System;
using Informedica.GenImport.GStandard.Attributes;
using Informedica.GenImport.GStandard.DomainModel.Enums;
using Informedica.GenImport.GStandard.DomainModel.Interfaces;

namespace Informedica.GenImport.GStandard.DomainModel
{
    public class Composition : Entity<Composition>, IComposition
    {
        #region Implementation of IComposition

        /// <summary>
        /// Mutatiekode
        /// </summary>
        [FileLinePosition(5, 5)]
        public virtual MutKod MutKod { get; set; }

        /// <summary>
        /// Thesaurus verwijzing soort code
        /// </summary>
        [FileLinePosition(6, 9)]
        public virtual short ThsrTc { get; set; }

        /// <summary>
        /// Soort code
        /// </summary>
        [FileLinePosition(10, 15)]
        public virtual int SrtCde { get; set; }

        /// <summary>
        /// Code
        /// </summary>
        [FileLinePosition(16, 23)]
        public virtual int Code { get; set; }

        /// <summary>
        /// GeneriekeNaamKode (GNK)
        /// </summary>
        [FileLinePosition(24, 29)]
        [Modulo11]
        public virtual int GnGnK { get; set; }

        /// <summary>
        /// Hoeveelheid generiek naam
        /// </summary>
        [DecimalFormat(3)]
        [FileLinePosition(30, 41)]
        public virtual decimal GnHoev { get; set; }

        /// <summary>
        /// Thesaurusverwijzig eenh. hoeveelh. generiek naam
        /// </summary>
        [FileLinePosition(42, 45)]
        public virtual short TsGneH { get; set; }

        /// <summary>
        /// Eenheid hoeveelheid generieke naam
        /// </summary>
        [FileLinePosition(46, 51)]
        public virtual int GnEenh { get; set; }

        /// <summary>
        /// Stamnaamcode (SNK)
        /// </summary>
        [FileLinePosition(52, 57)]
        [Modulo11]
        public virtual int GnStam { get; set; }

        /// <summary>
        /// Hoeveelheid stamnaam
        /// </summary>
        [DecimalFormat(3)]
        [FileLinePosition(58, 69)]
        public virtual decimal StHoev { get; set; }

        /// <summary>
        /// Thesaurusverwijzig eenh. hoeveelh. stamnaam
        /// </summary>
        [FileLinePosition(70, 73)]
        public virtual short TsStEh { get; set; }

        /// <summary>
        /// Eenheid hoeveelheid stamnaam
        /// </summary>
        [FileLinePosition(74, 79)]
        public virtual int StEenh { get; set; }

        /// <summary>
        /// Sterktes mogen worden opgeteld J/N
        /// </summary>
        [BooleanFormat("J", "N")]
        [FileLinePosition(80, 80)]
        public virtual bool StAdd { get; set; }

        #endregion

        #region Overrides of Entity<Composition,int>

        public override bool IsIdentical(Composition entity)
        {
            return IsIdentical(entity);
        }

        #endregion

        #region Implementation of IEntity<in IComposition,out int>

        public virtual bool IsIdentical(IComposition entity)
        {
            return entity.Code == Code && entity.GnEenh == GnEenh && entity.GnGnK == GnGnK && entity.GnHoev == GnHoev &&
                   entity.SrtCde == SrtCde;
        }

        #endregion

        #region Implementation of ICopyable<in IComposition>

        public virtual void CopyTo(IComposition other)
        {
            other.Code = Code;
            other.GnEenh = GnEenh;
            other.GnGnK = GnGnK;
            other.GnHoev = GnHoev;
            other.GnStam = GnStam;
            other.MutKod = MutKod;
            other.SrtCde = SrtCde;
            other.StAdd = StAdd;
            other.StEenh = StEenh;
            other.StHoev = StHoev;
            other.ThsrTc = ThsrTc;
            other.TsGneH = TsGneH;
            other.TsStEh = TsStEh;
        }

        #endregion
    }
}
