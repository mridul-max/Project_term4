using System;
using System.Collections.Generic;
using System.Linq;
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
            List<Table> tables = tabledao.GetAllTables();
            return tables;
        }
        public Table GetById(int id)
        {
            Table table = tabledao.GetById(id);
            return table;
        }
    }
}
