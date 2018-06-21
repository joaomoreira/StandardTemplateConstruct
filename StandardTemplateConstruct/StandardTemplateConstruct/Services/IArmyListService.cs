using StandardTemplateConstruct.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StandardTemplateConstruct.Services
{
    public interface IArmyListService
    {
        IList<ArmyList> GetAll();

        ArmyList Add(ArmyList armyList);
        ArmyList Get(int id);
        ArmyList Update(ArmyList armyList);
    }
}
