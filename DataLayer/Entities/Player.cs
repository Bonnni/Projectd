using System;

namespace DataLayer.Entities
{
    public class Player
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string BirthDay { get; set; }
        public string Country { get; set; }
        public int? TeamId { get; set; }
        public Team Team { get; set; }
    }
}
