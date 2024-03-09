﻿using System.ComponentModel.DataAnnotations;

namespace DAL.Models;

public class Project
{
    public Guid Id { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    public string Customer { get; set; }

    [Required]
    public string Executor { get; set; }
    public List<Employee> Employees { get; set; } = [];

    [Required]
    public Guid LeaderId { get; set; }
    public Employee Leader { get; set; }

    [Required]
    public DateOnly StartDate { get; set; }

    [Required]
    public DateOnly EndDate { get; set; }

    [Required]
    public int Priority { get; set; }
}
