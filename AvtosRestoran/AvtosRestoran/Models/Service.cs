﻿using AvtosRestoran.Models.BaseModels;

namespace AvtosRestoran.Models
{
    public class Service:BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
    }
}
