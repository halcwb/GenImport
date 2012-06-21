using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using Informedica.GenImport.Library.DomainModel.GStandard;
using Informedica.GenImport.Library.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Informedica.GenImport.Library.Tests
{
    [TestClass]
    public class ThesauriTotaalShould
    {
        private readonly Type _naamType = typeof(ThesauriTotaal);
        private const BindingFlags TestBindingFlags = BindingFlags.Public | BindingFlags.Instance;

        [TestMethod]
        public void Have_A_LinePositionAttribute_On_All_Known_Public_Properties()
        {
            var thesauriTotaal = new ThesauriTotaal();
            var expectedPositionsOnProperties = new Dictionary<MemberInfo, int[]>
            {
                {ReflectionUtility.GetMemberInfo(() => thesauriTotaal.MutKod), new[]{5, 5}},
                {ReflectionUtility.GetMemberInfo(() => thesauriTotaal.TsNr), new[]{6, 9}},
                {ReflectionUtility.GetMemberInfo(() => thesauriTotaal.TsItNr), new[]{10, 15}},
                {ReflectionUtility.GetMemberInfo(() => thesauriTotaal.ThItMk), new[]{16, 17}},
                {ReflectionUtility.GetMemberInfo(() => thesauriTotaal.ThNm4), new[]{18, 21}},
                {ReflectionUtility.GetMemberInfo(() => thesauriTotaal.ThNm15), new[]{22, 36}},
                {ReflectionUtility.GetMemberInfo(() => thesauriTotaal.ThNm25), new[]{37, 61}},
                {ReflectionUtility.GetMemberInfo(() => thesauriTotaal.ThNm50), new[]{62, 111}},
                {ReflectionUtility.GetMemberInfo(() => thesauriTotaal.ThAKd1), new[]{112, 112}},
                {ReflectionUtility.GetMemberInfo(() => thesauriTotaal.ThAKd2), new[]{113, 113}},
                {ReflectionUtility.GetMemberInfo(() => thesauriTotaal.ThAKd3), new[]{114, 114}},
                {ReflectionUtility.GetMemberInfo(() => thesauriTotaal.ThAKd4), new[]{115, 115}},
                {ReflectionUtility.GetMemberInfo(() => thesauriTotaal.ThAKd5), new[]{116, 116}},
                {ReflectionUtility.GetMemberInfo(() => thesauriTotaal.ThAKd6), new[]{117, 117}},
            };

            Assert.AreEqual(expectedPositionsOnProperties.Count, _naamType.GetProperties(TestBindingFlags).Count(),
                            "All properties must be tested on LinePositionAttribute");

            foreach (var expectedPositionsOnProperty in expectedPositionsOnProperties)
            {
                AttributeCheck.CheckIfPropertyHasLinePositionAttribute(expectedPositionsOnProperty);
            }
        }
    }
}
