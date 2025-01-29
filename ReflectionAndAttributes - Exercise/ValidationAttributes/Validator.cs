using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ValidationAttributes
{
    public static class Validator
    {
        public static bool IsValid(object obj)
        {
            Type type = obj.GetType();
            foreach (PropertyInfo property in type.GetProperties())
            {
                foreach (MyValidationAttribute attribute in property.GetCustomAttributes(typeof(MyValidationAttribute), true))
                {
                    bool isValid = attribute.IsValid(property.GetValue(obj));
                    if (!isValid)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
