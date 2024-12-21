﻿using System.ComponentModel.DataAnnotations;

namespace StudentInfo.Models.ViewModel
{
    public class AddStudentRequest
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        [Required]
        public string? Department { get; set; }
        public string? Session { get; set; }
    }
}
