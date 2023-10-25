using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;

namespace LayoutTemplateWebApp.Model
{
    public class Event
    {
        [Key]
        public int idEvent { get; set; }
        public string name { get; set; }
        public DateTime date { get; set; }
        
        public string description { get; set; }
        public string organizer { get; set; }
        public int capacityNumber { get; set; }
        public int idCapacityType { get; set; }
        public string entryCost { get; set; }

        [ForeignKey("EventType")]
		public int idEventType { get; set; }

		[ForeignKey("Facility")]
		public int idFacility { get; set; }

		[ForeignKey("Image")]
		public int idImage { get; set; }

        [ForeignKey("EventState")]
        public int idEventState { get; set; }

        // navigation properties
        public EventState EventState { get; set; }
		public Facility Facility { get; set; }
        public Image Image { get; set; }
		//public string EventType { get; set; }
		//public string EventState { get; set; }
	}
}
