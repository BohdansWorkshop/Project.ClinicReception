namespace Project.ClinicReception.ReceptionReference
{
    using System.Runtime.Serialization;
    using System;
    public partial class ClientModel
    {
        public override string ToString()
        {
            return $"{Name}";
        }
    }
}