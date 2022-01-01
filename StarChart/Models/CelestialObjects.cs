﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StarChart.Models
{
    public class CelestialObjects
    {
        public uint Id { get; set; }
        
        [Required]
        public string Name { get; set; }

        public int? OrbitedObjectId { get; set; }

        [NotMapped]
        public List<CelestialObjects> Satelites { get; set; }

        public TimeSpan OrbitalPeriod { get; set; }

    }
}
