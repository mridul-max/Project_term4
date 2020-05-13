using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using ChapeauDAL;
using ChapeauModel;

namespace ChapeauLogic
{
    //class for communication with dao and ui layer.
    public class TableService
    {
        TableDAO tabledao = new TableDAO();

        public List<Table> GetAllTables()
        {
            try
            {
                return tabledao.GetAllTables();
            }
            catch
            {
                string errorstr = "Chapeau App couldn't get the tables";
                ErrorDAO error = new ErrorDAO(errorstr);
                return null;
            }
          
            
        }
        public Table GetById(int id)
        {          
            try
            {
                return tabledao.GetById(id);
            }
            catch
            {
                string errorstr = "Chapeau App couldn't get the table";
                ErrorDAO error = new ErrorDAO(errorstr);
                return null;
            }
        }
    }
}
