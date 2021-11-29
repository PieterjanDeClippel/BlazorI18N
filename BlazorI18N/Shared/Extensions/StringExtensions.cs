namespace BlazorI18N.Shared.Extensions
{
    public static class StringExtensions
    {
        public static string UcFirst(this string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return str;
            }
            else
            {
                return char.ToUpper(str[0]) + str.Substring(1);
            }
        }
    }
}
