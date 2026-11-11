using System.ComponentModel.DataAnnotations;

namespace WebApplication5.Entity
{
    public class Address : Entity
    {

        public string AddressDetails { get; set; }
        public string City { get; set; }

        public string State { get; set; }


        //relations
        public int StudentId { get; set; }

        public virtual Student Student { get; set; }
    }
}
