using neyeyim.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace neyeyim.ViewModels
{
    public class PlaceDetailViewModel
    {
        public Place Place { get; set; }
        public List<Place> Places { get; set; }
    }
}