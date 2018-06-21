using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StandardTemplateConstruct.Models
{
    public class ArmyList
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Unit> Units { get; set; }
    }
}
