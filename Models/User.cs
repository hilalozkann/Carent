namespace RentProject.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int GovIdNo { get; set; }
        public string address { get; set; }
        public int PhoneNumber { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public bool verifiedAccount { get; set; }
        public string BankAccount { get; set; }
        public string profilepic { get; set; }


    }
}
