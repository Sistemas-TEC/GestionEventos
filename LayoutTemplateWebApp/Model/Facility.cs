using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LayoutTemplateWebApp.Model
{
    public class Facility
    {
        [Key]
        public int idFacility { get; set; }

        [DisplayName("Nombre")]
        public string name { get; set; }


        [DisplayName("Capacidad")]
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
        [DisplayName("Tipo de Instalación")]
        public FacilityType FacilityType { get; set; }


        [DisplayName("Ubicación")]
        public Location Location { get; set; }

        [DisplayName("Imagen")]
        public Image Image { get; set; }

        [DisplayName("Administrador")]
        public FacilityAdministrator FacilityAdministrator { get; set; }
		
	}
}
