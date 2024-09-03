﻿using System.ComponentModel.DataAnnotations;

namespace gp_backend.Core.Models
{
    public class Disease
    {
        public int Id { get; set; }
        [StringLength(150)]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Risk { get; set; }
        public List<string> Preventions { get; set; } = [];
        public List<Specialization>? Specialization { get; set; } = [];
    }
}