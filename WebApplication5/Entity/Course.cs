using Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication5.Entity
{
    public class Course : Entity
    {


        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        public string CourseCode { get; set; }


        #region Relations

        public int TeacherId { get; set; }
        public virtual Teacher Teacher { get; set; }
        #endregion


    }
}
