﻿using System.ComponentModel.DataAnnotations;

namespace TaskManager2.Models
{
    public class Task
    {
        [Key]
        public int TaskId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsCompleted { get; set; }
    }
}
