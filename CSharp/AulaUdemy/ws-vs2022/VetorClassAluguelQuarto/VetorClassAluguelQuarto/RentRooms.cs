namespace VetorClassAluguelQuarto
{
    public class RentRooms
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public RentRooms(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public override string ToString()
        {
            return $"{Name}, {Email}";
        }
    }
}
