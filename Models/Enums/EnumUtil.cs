using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace FinanceApp.Models.Enums
{
  public class EnumUtil
  {
    public static IEnumerable<T> GetValues<T>()
    {
      return Enum.GetValues(typeof(T)).Cast<T>();
    }

    public static string GetEnumDescription(Enum value)
    {
      FieldInfo fi = value.GetType().GetField(value.ToString());

      DescriptionAttribute[] attributes =
          (DescriptionAttribute[])fi.GetCustomAttributes(
          typeof(DescriptionAttribute),
          false);

      if (attributes != null &&
          attributes.Length > 0)
        return attributes[0].Description;
      else
        return value.ToString();
    }
  }
}