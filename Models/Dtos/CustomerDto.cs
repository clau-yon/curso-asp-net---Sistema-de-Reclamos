namespace WebApplicationSistemaDeReclamos.Models.Dtos
{
    public class CustomerDto
    {
        private long id;
        private string name;
        private string email;
        private string phone;
        private string city;

        public CustomerDto() { }
        public CustomerDto(long id, string name, string email, string phone, string city)
        {
            this.Id = id;
            this.Name = name;
            this.Email = email;
            this.Phone = phone;
            this.City = city;
        }

        public long Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public string Phone { get => phone; set => phone = value; }
        public string City { get => city; set => city = value; }
    }
}
