using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgencyApp.Model
{
    [Table("Voyage", Schema = "dbo")]
    public class Voyage
    {
        [Key]
        [Column("VoyageId")]
        public int VoyageId { get; set; }
        [Required]
        [MaxLength(50)]
        [Column("Titre")]
        public string Titre { get; set; }
        [Required]
        [MaxLength(150)]
        [Column("Description")]
        public string Description { get; set; }
        [Required]
        [MaxLength(60)]
        [Column("Destinations")]
        public string Destinations { get; set; }
        [Required]
        [Column("DateDepart")]
        public DateTime DateDepart { get; set; }
        [Required]
        [Column("DateRetour")]
        public DateTime DateRetour { get; set; }
        [Required]
        [Column("Prix")]
        public decimal Prix { get; set; }
        [Required]
        [Column("NombrePlacesDisponibles")]
        public int NombrePlacesDisponibles { get; set; }
        [ForeignKey("Guide")]
        public int GuideId { get; set; }
        public Guide Guide { get; set; }
        [InverseProperty("Voyages")]
        public ICollection<Client> clients { get; set; }
    }
}
