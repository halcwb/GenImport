﻿using System;
using System.Reflection;
using Informedica.GenImport.GStandard.Attributes;
using Informedica.GenImport.GStandard.DomainModel.Interfaces;
using Informedica.GenImport.Library.Exceptions;
using Informedica.GenImport.Library.Reflection;
using Informedica.GenImport.Library.Serialization;
using Informedica.GenImport.Library.Validation;

namespace Informedica.GenImport.GStandard.Serialization
{
    public class GStandardFileSerializer<TModel> : FileSerializer<TModel>
        where TModel : class, IGStandardModel, new()
    {
        //TODO make this: bool TryParseLineToModel(string line, out TModel model)
        //TODO add PostSharp
        protected override TModel ParseLineToModel(string line)
        {
            //last line, just skip
            if (line.IndexOf((char)26) >= 0) return null;

            try
            {
                TModel model = new TModel();
                foreach (var properyInfo in ReflectionUtility.GetProperties<TModel, FileLinePositionAttribute>())
                {
                    object value = GetValue(properyInfo, line);
                    properyInfo.SetValue(model, value, null);
                }

                //TODO when to validate model? And what do we do with the result(s)?
                Validator.Validate(model);

                return model;
            }
            catch (Exception ex)
            {
                throw new CannotParseLineException(ex);
            }
        }

        private static object GetValue(PropertyInfo properyInfo, string line)
        {
            var positionAttribute = ReflectionUtility.GetAttribute<FileLinePositionAttribute>(properyInfo);

            string text = line.Substring(positionAttribute.StartPosition - 1,
                                         positionAttribute.EndPosition - positionAttribute.StartPosition + 1).Trim();

            if (ReflectionUtility.HasAttribute<BooleanFormatAttribute>(properyInfo))
            {
                return TryGetBoolean(properyInfo, text);
            }

            if (ReflectionUtility.HasAttribute<DecimalFormatAttribute>(properyInfo))
            {
                return TryGetDecimal(properyInfo, text);
            }

            return properyInfo.PropertyType.IsEnum
                       ? Enum.Parse(properyInfo.PropertyType, text)
                       : Convert.ChangeType(text, properyInfo.PropertyType);
        }

        private static bool TryGetBoolean(PropertyInfo properyInfo, string text)
        {
            bool result;
            if (ReflectionUtility.GetAttribute<BooleanFormatAttribute>(properyInfo).TryParse(text, out result))
            {
                return result;
            }
            throw new CannotParseLineException();
        }

        private static decimal TryGetDecimal(PropertyInfo properyInfo, string text)
        {
            decimal result;
            if (ReflectionUtility.GetAttribute<DecimalFormatAttribute>(properyInfo).TryParse(text, out result))
            {
                return result;
            }
            throw new CannotParseLineException();
        }
    }
}
