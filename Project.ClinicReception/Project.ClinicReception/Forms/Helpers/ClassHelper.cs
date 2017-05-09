using Project.ClinicReception.ReceptionReference;

namespace Project.ClinicReception.Helpers
{
    public static class ClassHelper
    {
        public static string GetClientForDisplay(this DoctorModel model)
        {
            return $"{model.Name}";
        }
    }
}