using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgencyApp.Model
{
    [Table("Personnel", Schema = "dbo")]
    public abstract class Personnel
    {
        [Key]
        [Column("PersonnelId")]
        public int PersonnelId { get; set; }
        [Column("Nom")]
        [Required]
        [MaxLength(50)]
        public string Nom { get; set; }
        [Column("Prenom")]
        [Required]
        [MaxLength(50)]
        public string Prenom { get; set; }
        [Column("Adresse")]
        [Required]
        [MaxLength(50)]
        public string Adresse { get; set; }
        [Column("DateNaissance")]
        [Required]
        public DateTime DateNaissance { get; set; }
        [Column("Genre")]
        [Required]
        [MaxLength(10)]
        public string Genre { get; set; }
        [Column("Salaire")]
        [Required]
        public decimal Salaire { get; set; }
    }
}
