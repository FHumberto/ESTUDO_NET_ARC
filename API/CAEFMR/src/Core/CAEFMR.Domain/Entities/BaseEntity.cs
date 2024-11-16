﻿namespace CAEFMR.Domain.Entities;

public abstract class BaseEntity
{
    public int Id { get; set; }
    public DateTime? CreatedDate { get; set; }
    public string? CreatedBy { get; set; }
    public DateTime? UpdatedDate { get; set; }
    public string? ModifiedBy { get; set; }
}