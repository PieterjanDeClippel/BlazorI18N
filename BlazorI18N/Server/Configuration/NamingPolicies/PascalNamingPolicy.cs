using BlazorI18N.Shared.Extensions;
using System.Text.Json;

namespace BlazorI18N.Server.Configuration
{
    public static class NamingPolicies
    {
        static NamingPolicies()
        {
            PascalNamingPolicy = new PascalNamingPolicy();
        }

        public static PascalNamingPolicy PascalNamingPolicy { get; }
    }

    public class PascalNamingPolicy : JsonNamingPolicy
    {
        internal PascalNamingPolicy()
        {
        }


        public override string ConvertName(string name)
        {
            return name.UcFirst();
        }
    }
}
