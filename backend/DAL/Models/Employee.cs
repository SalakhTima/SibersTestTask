﻿using System.ComponentModel.DataAnnotations;

namespace DAL.Models;

public class Employee
{
    public Guid Id { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    public string Surname { get; set; }

    [Required]
    public string Patronymic { get; set; }

    [Required]
    public string Email { get; set; }

    public List<Project> Projects { get; set; } = [];
}