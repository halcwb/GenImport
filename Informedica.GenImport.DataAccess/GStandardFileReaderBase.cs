using System;
using System.ComponentModel;
using System.Globalization;
using Informedica.GenImport.Library;
using Informedica.GenImport.Library.DomainModel.GStandard.Interfaces;
using Informedica.GenImport.Library.Exceptions;
using Informedica.GenImport.Library.Reflection;
using System.Reflection;

namespace Informedica.GenImport.DataAccess
{
    public abstract class GStandardFileReaderBase<TModel>
        where TModel : IGStandardModel, new()
    {


        protected virtual TModel ParseLineToModel(string line)
        {
            try
            {
                TModel model = new TModel();
                foreach (var properyInfo in typeof (TModel).GetProperties(BindingFlags.Public | BindingFlags.Instance))
                {
                    object value = GetValue(properyInfo, line);
                    properyInfo.SetValue(model, value, null);
                }

                return model;
            }
            catch(Exception ex)
            {
                throw new CannotParseLineException(ex);
            }
        }

        private static object GetValue(PropertyInfo properyInfo, string line)
        {
            var attribute = ReflectionUtility.GetAttribute<FileLinePositionAttribute>(properyInfo);

            string text = line.Substring(attribute.StartPosition - 1,
                                         attribute.EndPosition - attribute.StartPosition + 1).Trim();

            return properyInfo.PropertyType.IsEnum
                       ? Enum.Parse(properyInfo.PropertyType, text)
                       : Convert.ChangeType(text, properyInfo.PropertyType);
        }
    }
}
