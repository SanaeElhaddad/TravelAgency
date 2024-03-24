using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgencyApp.Model
{
    [Table("Client", Schema = "dbo")]
    public class Client
    {
        [Key]
        [Column("ClientId")]
        public int ClientId { get; set; }

        [Required]
        [MaxLength(50)]
        [Column("Nom")]
        public string Nom { get; set; }

        [Required]
        [MaxLength(50)]
        [Column("Prenom")]
        public string Prenom { get; set; }

        [Required]
        [MaxLength(50)]
        [Column("NumeroTelephone")]
        public string NumeroTelephone { get; set; }

        [Required]
        [Column("DateNaissance")]
        public DateTime DateNaissance { get; set; }

        [Required]
        [MaxLength(10)]
        [Column("Genre")]
        public string Genre { get; set; }

        [InverseProperty("clients")]
        public ICollection<Voyage> Voyages { get; set; }
    }
}
