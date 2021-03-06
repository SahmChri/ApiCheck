﻿using System.Reflection;

namespace ApiCheck.Utility
{
  internal static class ConstructorInfoExtemsions
  {
    public static string GetCompareableName(this ConstructorInfo constructorInfo)
    {
      return string.Format("{0}{1}", constructorInfo.ReflectedType.GetCompareableName(), constructorInfo.Name);
    }
  }
}
