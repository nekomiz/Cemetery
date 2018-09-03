﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace lastCemetery3.Models
{
    public class Sector
    {
        public int Id { get; set; }
        public string SectorName { get; set; }        
        public DateTime CreatedAt { get; set; }

        // foreign key
        [JsonIgnore]
        public int CemeteryId { get; set; }
        //[JsonIgnore]
        public Cemetery Cemetery { get; set; }

        // navigation property
        [JsonIgnore]
        public List<Place> Places { get; set; }
        public Sector()
        {
            Places = new List<Place>();
        }
    }
}
