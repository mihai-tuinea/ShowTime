﻿using ShowTime.Enums;
using System.ComponentModel.DataAnnotations;

namespace ShowTime.Entities
{
    public class Band
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Band Name must not be empty")]
        public string? Name { get; set; }
        public Genre Genre { get; set; }
        public ICollection<FestivalBand> FestivalBands { get; set; } = [];
        public ICollection<Member> Members { get; set; } = [];
        public byte[]? Image { get; set; }
    }
}
