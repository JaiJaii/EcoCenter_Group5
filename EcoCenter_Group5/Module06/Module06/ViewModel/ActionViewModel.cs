using EcoCenter_Group5.Model;
using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.EntityFrameworkCore;
using System.IO;
using System.Threading.Tasks;

namespace EcoCenter_Group5.ViewModel
{
   
    class ActionViewModel
    {

        private Services.DatabaseContext getContext()
        {
            return new Services.DatabaseContext();
        }
        public  int InsertAction(ActionModel obj)
        {
            var _dbContext = getContext();
            _dbContext.Actions.Add(obj);
            int c = _dbContext.SaveChanges();
            return c;
        }

        public async Task<List<ActionModel>> GetAllActions()
        {
            var _dbContext = getContext();
            var res = await _dbContext.Actions.ToListAsync();
            return res;
        }
        public async Task<int> UpdateAction(ActionModel obj)
        {
            var _dbContext = getContext();

            _dbContext.Actions.Update(obj);
            int c = await _dbContext.SaveChangesAsync();
            return c;

        }
        public int DeleteAction(ActionModel obj) 
        {
            var _dbContext = getContext();
            _dbContext.Actions.Remove(obj);
            int c = _dbContext.SaveChanges();
            return c; 

        }
    }
}
