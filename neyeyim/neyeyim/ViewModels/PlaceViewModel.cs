using neyeyim.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace neyeyim.ViewModels
{
    public class PlaceViewModel
    {
        public List<Place> Places { get; set; }
        public List<Place> FilterPlaces { get; set; }
        public List<PlaceTag> PlaceTags { get; set; }
    }
}