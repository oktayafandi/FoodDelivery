using neyeyim.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace neyeyim.ViewModels
{
    public class HomeViewModel
    {
        public List<Slider> Sliders { get; set; }
        public List<Place> Places { get; set; }
        public List<PlaceComment> PlaceComments { get; set; }
        public List<PlaceImage> PlaceImages { get; set; }
    }
}