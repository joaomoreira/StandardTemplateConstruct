using StandardTemplateConstruct.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StandardTemplateConstruct.Services
{
    public class ArmyListServiceOnMemoryData : IArmyListService
    {
        private IList<ArmyList> _armyLists;

        public ArmyListServiceOnMemoryData()
        {
            _armyLists = new List<ArmyList>()
            {
                new ArmyList(){Id = 1, Name = "Space Marines"},
                new ArmyList(){Id = 2, Name = "Tyranids"}
            };
        }

        public ArmyList Add(ArmyList armyList)
        {
            armyList.Id = _armyLists.Max(al => al.Id)+1;
            _armyLists.Add(armyList);
            return armyList;
        }

        public ArmyList Get(int id)
        {
            return _armyLists.FirstOrDefault(al => al.Id== id);
        }

        public ArmyList Update(ArmyList armyList)
        {
            ArmyList oldList = _armyLists.FirstOrDefault(al => al.Id == armyList.Id);

            oldList.Name = armyList.Name;
          
            return armyList;
        }

        public IList<ArmyList> GetAll()
        {
            return _armyLists;
        }
    }
}
