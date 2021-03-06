﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Entities.Models
{
    public class Region
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public virtual ICollection<Apartment> Apartments { get; set; }

        public virtual ICollection<House> Houses { get; set; }
    }
}
