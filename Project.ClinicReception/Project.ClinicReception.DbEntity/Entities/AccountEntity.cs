namespace Project.ClinicReception.DbEntity
{
    public class AccountEntity : IdEntity
    {

        public string Login { get; set; }
        public string Password { get; set; }
        public override string ToString()
        {
            return $" Login: {Login}, Pass: {Password}";
        }
    }
}