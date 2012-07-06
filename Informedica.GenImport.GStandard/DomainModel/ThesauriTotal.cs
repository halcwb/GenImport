﻿using System;
using Informedica.GenImport.GStandard.Attributes;
using Informedica.GenImport.GStandard.DomainModel.Enums;
using Informedica.GenImport.GStandard.DomainModel.Interfaces;

namespace Informedica.GenImport.GStandard.DomainModel
{
    public class ThesauriTotal : Entity<ThesauriTotal>, IThesauriTotal
    {
        #region Implementation of IThesauriTotaal

        /// <summary>
        /// Mutatiekode
        /// </summary>
        [FileLinePosition(5, 5)]
        public virtual MutKod MutKod { get; set; }

        /// <summary>
        /// Thesaurusnummer (in nieuwe thesauri)
        /// </summary>
        [FileLinePosition(6, 9)]
        public virtual short TsNr { get; set; }

        /// <summary>
        /// Thesaurus itemnummer (in nieuwe thesauri)
        /// </summary>
        [FileLinePosition(10, 15)]
        public virtual int TsItNr { get; set; }

        /// <summary>
        /// Memokode item
        /// </summary>
        [FileLinePosition(16, 17)]
        public virtual string ThItMk { get; set; }

        /// <summary>
        /// Naam item 4 posities
        /// </summary>
        [FileLinePosition(18, 21)]
        public virtual string ThNm4 { get; set; }

        /// <summary>
        /// Naam item 15 posities
        /// </summary>
        [FileLinePosition(22, 36)]
        public virtual string ThNm15 { get; set; }

        /// <summary>
        /// Naam item 25 posities
        /// </summary>
        [FileLinePosition(37, 61)]
        public virtual string ThNm25 { get; set; }

        /// <summary>
        /// Naam item 50 posities
        /// </summary>
        [FileLinePosition(62, 111)]
        public virtual string ThNm50 { get; set; }

        /// <summary>
        /// Aanvullende kode 1
        /// </summary>
        [FileLinePosition(112, 112)]
        public virtual string ThAKd1 { get; set; }

        /// <summary>
        /// Aanvullende kode 2
        /// </summary>
        [FileLinePosition(113, 113)]
        public virtual string ThAKd2 { get; set; }

        /// <summary>
        /// Aanvullende kode 3
        /// </summary>
        [FileLinePosition(114, 114)]
        public virtual string ThAKd3 { get; set; }

        /// <summary>
        /// Aanvullende kode 4
        /// </summary>
        [FileLinePosition(115, 115)]
        public virtual string ThAKd4 { get; set; }

        /// <summary>
        /// Aanvullende kode 5
        /// </summary>
        [FileLinePosition(116, 116)]
        public virtual string ThAKd5 { get; set; }

        /// <summary>
        /// Aanvullende kode 6
        /// </summary>
        [FileLinePosition(117, 117)]
        public virtual string ThAKd6 { get; set; }

        #endregion

        #region Overrides of Entity<ThesauriTotal,int>

        public override bool IsIdentical(ThesauriTotal entity)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
