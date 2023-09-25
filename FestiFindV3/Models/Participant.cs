using System.ComponentModel.DataAnnotations;

namespace FestFindV2.Models
{
    public class Participant
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public List<Order> orders { get; set; } = new List<Order>();

        public static void ShowTickets(Order orderId)
        {
            //tickets weergeven
        }
        public static void ReserveTicket(Event eventId)
        {
            //create order by chosen eventId
        }
        public static void DeleteTicket(Order orderId)
        {
            //Delete ticket by orderId
        }
    }
}
