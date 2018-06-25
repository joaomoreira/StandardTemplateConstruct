using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StandardTemplateConstruct.Data;
using StandardTemplateConstruct.Models;

namespace StandardTemplateConstruct.Services
{
    public class ArmyListServiceSqlData : IArmyListService
    {
        private StandardTemplateConstructDbContext _context;

        public ArmyListServiceSqlData(StandardTemplateConstructDbContext context)
        {
            _context = context;
        }

        public ArmyList Add(ArmyList armyList)
        {
            _context.ArmyLists.Add(armyList);
            _context.SaveChanges();

            return armyList;
        }

        public ArmyList Get(int id)
        {
            return _context.ArmyLists.FirstOrDefault(r => r.Id == id);
        }

        public IList<ArmyList> GetAll()
        {
            return _context.ArmyLists.OrderBy(r => r.Name).ToList();
        }

        public ArmyList Update(ArmyList armyList)
        {
            _context.Attach(armyList).State = EntityState.Modified;
            _context.SaveChanges();

            return armyList;
        }
    }
}
