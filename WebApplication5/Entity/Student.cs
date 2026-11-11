using System.ComponentModel.DataAnnotations;

namespace WebApplication5.Entity
{
    public class Student : Entity
    {


        public string FirstName { get; set; }

        public string LastName { get; set; }

        //relations

        public virtual Address Address { get; set; }
    }
}
