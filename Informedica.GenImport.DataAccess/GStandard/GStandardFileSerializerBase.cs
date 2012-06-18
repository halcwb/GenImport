using System;
using System.Reflection;
using Informedica.GenImport.Library;
using Informedica.GenImport.Library.DomainModel.Interfaces;
using Informedica.GenImport.Library.Exceptions;
using Informedica.GenImport.Library.Reflection;

namespace Informedica.GenImport.DataAccess.GStandard
{
    public abstract class GStandardFileSerializerBase<TModel> : FileSerializerBase<TModel>
        where TModel : class, IGStandardModel, new()
    {
        protected override TModel ParseLineToModel(string line)
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
