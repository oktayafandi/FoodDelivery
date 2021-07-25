using neyeyim.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace neyeyim.ViewModels
{
    public class InfoViewModel
    {
        public List<Info> Information { get; set; }
        public List<Promotion> Promotions { get; set; }
        public List<Setting> Settings { get; set; }
    }
}
