using neyeyim.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace neyeyim.ViewModels
{
    public class BasketItemOrderVm
    {
        public List<BasketItemViewModel> basket { get; set; }
        public Order orderModel { get; set; }
        public string AppUserId { get; set; }
        public Order order { get; set; } 
        public string Address { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string ContactPhone { get; set; }
        public string Note { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
