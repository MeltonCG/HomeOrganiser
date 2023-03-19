using MELT.BlazorComponents.Attributes;
using System.Reflection;

namespace MELT.BlazorComponents.Extensions
{
    public static class EnumExtensions
    {
        public static string GetDisplayDescription(this Enum e)
        {
            string result = string.Empty;

            Type enumType = e.GetType();

            foreach (FieldInfo fi in enumType.GetFields(BindingFlags.Static | BindingFlags.GetField | BindingFlags.Public))
            {
                int value = (int)fi.GetValue(null);

                // if we have a match:
                if (value == Convert.ToInt32(e))
                {
                    object[] attr = fi.GetCustomAttributes(typeof(DisplayDescription), false);

                    if (attr.Length > 0)
                    {
                        DisplayDescription d = (DisplayDescription)attr[0];
                        result = d.NameToShow;
                    }
                }
            }

            return result;
        }
    }
}
