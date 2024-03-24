using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgencyApp.Model
{
    [Table("Guide", Schema = "dbo")]
    public class Guide : Personnel
    {
        [Required]
        [MaxLength(50)]
        [Column("LanguesParlees")]
        public string LanguesParlees { get; set; }
    }
}
