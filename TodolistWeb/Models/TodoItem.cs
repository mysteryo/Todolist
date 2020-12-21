using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodolistWeb.Models
{
    public class TodoItem
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool IsCompleted { get; set; }

    }
}
