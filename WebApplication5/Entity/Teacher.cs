using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication5.Entity
{
    public class Teacher : Entity
    {


        public string Name { get; set; }

        #region Relations
        public virtual List<Course> courses { get; set; }

        #endregion

    }
}
