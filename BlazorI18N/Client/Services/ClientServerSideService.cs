using BlazorI18N.Shared.Services;

namespace BlazorI18N.Client.Services
{
    internal class ClientServerSideService : IClientServerSideService
    {
        public bool IsServerSide => false;
    }
}
