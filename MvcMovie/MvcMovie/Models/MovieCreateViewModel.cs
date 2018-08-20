using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;

namespace MvcMovie.Models
{
    public class MovieCreateViewModel
    {
        public int ID { get; set; }
        public string title { get; set; }

        public DateTime releaseDate { get; set; }

        public decimal price { get; set; }

        public string rating { get; set; }

        public List<SelectListItem> movieType;
    }

}