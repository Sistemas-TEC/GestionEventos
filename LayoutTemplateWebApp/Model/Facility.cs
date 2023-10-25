using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LayoutTemplateWebApp.Model
{
    public class Facility
    {
        [Key]
        public int idFacility { get; set; }

        public string name { get; set; }



        public int capacity { get; set; }

		[ForeignKey("FacilityType")]
		public int idFacilityType { get; set; }

		[ForeignKey("Location")]
		public int idLocation { get; set; }

		[ForeignKey("Image")]
		public int idImage { get; set; }

		[ForeignKey("FacilityAdministrator")]
		public int idFacilityAdministrator { get; set; }

		// navigation properties
		public FacilityType FacilityType { get; set; }
		public Location Location { get; set; }
		public Image Image { get; set; }
		public FacilityAdministrator FacilityAdministrator { get; set; }
		
	}
}
