using BlazorI18N.Shared.Services;

namespace BlazorI18N.Server.Services
{
    internal class ClientServerSideService : IClientServerSideService
    {
        public bool IsServerSide => true;
    }
}
