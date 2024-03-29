﻿using System.ComponentModel.DataAnnotations;

namespace FestFindV2.Models
{
    public class Event
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        public DateTime Date_Time { get; set; }
        [Required]
        public float Costs { get; set; }
        [Required]
        public int MaxParticipants { get; set; }
        public List<Participant> Participants { get; set; } = new List<Participant>();
        public List<Cashier> Cashiers { get; set; } = new List<Cashier>();
    }
}
