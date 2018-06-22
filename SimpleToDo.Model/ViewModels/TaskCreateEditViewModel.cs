﻿using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace SimpleToDo.Model.ViewModels
{
    public class TaskCreateEditViewModel
    {
        [HiddenInput]
        public int TodoListId { get; set; }

        public int Id { get; set; }

        [Required, MaxLength(500)]
        public string Name { get; set; }

        [MaxLength(4000)]
        public string Description { get; set; }

        public bool Done { get; set; }
    }
}