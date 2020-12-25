using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;


namespace CompanyName.ProjectName.Common.Framework.Enum
{
    public static class EnumExtensions
    {
        private static T GetAttribute<T>(this Enum value) where T : Attribute
        {
            try
            {
                var type = value.GetType();
                var memberInfo = type.GetMember(value.ToString());
                var attributes = memberInfo[0].GetCustomAttributes(typeof(T), false);
                return (T)attributes.FirstOrDefault(); //attributes.Length > 0 ? (T)attributes[0] : null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static Dictionary<string, object> ToDisplay(this Enum value, Expression<Func<PropertyInfo, bool>> expression = null)
        {
            try
            {
                Dictionary<string, object> _dict = new Dictionary<string, object>();
                var attribute = value.GetAttribute<DisplayAttribute>();
                Expression<Func<PropertyInfo, bool>> _expression = m => m.Name != "AutoGenerateField" && m.Name != "AutoGenerateFilter" && m.Name != "Order" && m.Name != "TypeId";
                _expression = expression != null ? expression : _expression;
                foreach (PropertyInfo item in attribute.GetType().GetProperties().Where(_expression.Compile()).ToList())
                {
                    if (item.GetValue(attribute, null) != null)
                    {
                        _dict.Add(item.Name, item.GetValue(attribute, null));
                    }
                }
                return _dict;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static string ToDisplayDescription(this Enum value)
        {
            try
            {
                var attribute = value.GetAttribute<DisplayAttribute>();
                return attribute == null ? value.ToString() : attribute.Description;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static string ToDisplayName(this Enum value)
        {
            try
            {
                var attribute = value.GetAttribute<DisplayAttribute>();
                return attribute == null ? value.ToString() : attribute.Name;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static string ToDescription(this Enum value)
        {
            try
            {
                var attribute = value.GetAttribute<DescriptionAttribute>();
                return attribute == null ? value.ToString() : attribute.Description;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
