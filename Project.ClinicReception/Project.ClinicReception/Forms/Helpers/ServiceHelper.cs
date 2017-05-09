using Project.ClinicReception.ReceptionReference;

namespace Project.ClinicReception.Helpers
{
    public static class ServiceHelper
    {
        public static ReceptionServiceClient Client { get; } = new ReceptionServiceClient();
    }
}