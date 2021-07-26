using neyeyim.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace neyeyim.ViewModels
{
    public class JobadDetailViewModel
    {
        public Jobad Jobad { get; set; }
        public List<Jobad> Jobads { get; set; }
    }
}
