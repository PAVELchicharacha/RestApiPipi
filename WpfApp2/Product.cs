using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public DateTime SellDate { get; set; }
        [Required]
        public string Name { get; set; }
        public int SoldCount { get; set; }
        [Required]
        public int SoldPrice { get; set; }
    }
}
