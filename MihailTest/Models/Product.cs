using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MihailTest.Models
{
    public class Product : IBaseEntity
    {
        [Key]
        public int Id { get; set; }

        [Required(AllowEmptyStrings = true)]
        public string Name { get; set; }

        public string Description { get ; set ; }

        public decimal Price { get; set; }

        public DateTime CreateDate{ get; set; }

        public DateTime ShelfLifeToDate { get; set; }

        public  int CategoryId { get; set; }


        public virtual Category Category { get; set; }
    }
}
