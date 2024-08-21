using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace CountryAPI.Models
{
    public class Country
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string CountryName { get; set; }

        [StringLength(100)]
        public string Capital { get; set; }
    }
}