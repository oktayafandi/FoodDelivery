using neyeyim.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace neyeyim.ViewModels
{
    public class BasketItemViewModel
    {
        public int Id { get; set; }
        public string FoodName { get; set; }
        public decimal FoodPrice { get; set; }
        public int Count { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
