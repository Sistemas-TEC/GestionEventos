using System.ComponentModel.DataAnnotations;

namespace LayoutTemplateWebApp.Model
{
    public class FacilityAdministrator
    {
        [Key]
        public int idFacilityAdministrator { get; set; }

        [Required]
        [MaxLength(255)]
        public string email { get; set; }


		// navigation properties
		public ICollection<Facility> facilities { get; set; }
	}
}
