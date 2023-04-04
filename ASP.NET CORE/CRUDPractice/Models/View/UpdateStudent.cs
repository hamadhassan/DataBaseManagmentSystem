namespace CRUDPractice.Models.View
{
    public class UpdateStudent
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string RegistrationNumber { get; set; }
        public long PhoneNumber { get; set; }
        public string City { get; set; }
        public string University { get; set; }
    }
}
