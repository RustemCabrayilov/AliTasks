﻿namespace AvtosRestoran.Models.BaseModels
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public bool IsDeleted { get; set; }
    }
}
