﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NeoEducationSystem.Data.Models;

public class Paragraph
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Content { get; set; } = null!;

    public string? Code { get; set; }

    [ForeignKey(nameof(Lesson))]
    public int LessonId { get; set; }

    [Required]
    public virtual Lesson Lesson { get; set; } = null!;
}