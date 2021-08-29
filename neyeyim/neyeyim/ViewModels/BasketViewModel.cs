using neyeyim.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace neyeyim.ViewModels
{
    public class BasketViewModel
    {
        public List<PlaceMenu> placeMenus { get; set; }
        public List<BasketItemViewModel> BasketItems { get; set; }
        public decimal TotalPrice { get; set; }
        public int Count { get; set; }
        public Place Place { get; set; }
    }
}
