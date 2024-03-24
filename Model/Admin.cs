using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgencyApp.Model
{
    [Table("Admin", Schema = "dbo")]
    public class Admin : Personnel
    {
        [Required]
        [Column("Login")]
        [MaxLength(10)]
        public string Login { get; set; }
        [Required]
        [Column("MotDePass")]
        [MaxLength(10)]
        public string MotDePass { get; set; }
    }
}
