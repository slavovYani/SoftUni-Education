﻿
namespace ValidationAttributes
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Reflection.Metadata.Ecma335;
    using ValidationAttributes.Utilities;

    public static class Validator
    {
        public static bool IsValid(object obj)
        {
            Type objType = obj.GetType();

            PropertyInfo[] properties = objType.GetProperties().
                Where(p => p.CustomAttributes.
                Any(ca => typeof(MyValidationAttribute).
                IsAssignableFrom(ca.AttributeType))).ToArray();


            foreach (PropertyInfo validationProp in properties)
            {
                // more than one custom attribute for one property!!

                object[] customAttributes = validationProp
                       .GetCustomAttributes()
                       .Where(ca => typeof(MyValidationAttribute).IsAssignableFrom(ca.GetType()))
                       .ToArray();

                object propValue = validationProp.GetValue(obj);

                foreach (object customAttribute in customAttributes)
                {
                    MethodInfo isValidMethod = customAttribute.GetType()
                        .GetMethods(BindingFlags.Instance | BindingFlags.Public)
                        .FirstOrDefault(mi => mi.Name == "IsValid");

                    bool result = (bool)isValidMethod.Invoke(customAttribute, new object[] { propValue });

                    if (!result)
                    {
                        return false;
                    }
                }
            }
            return true;

            

        }
        
    }
}
