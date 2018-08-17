using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MvcMovie.Models
{
    public class MovieType
    {
        public int ID { get; set; }
        public string Type { get; set; }
    }
}