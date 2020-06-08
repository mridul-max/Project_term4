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
                throw;
            }
                    
        }
        public void SetOccupied(Table table)
        {
            try
            {
                tabledao.SetOccupied(table);
            }
            catch
            {
                string errorstr = "Chapeau App couldn't set the tables";
                ErrorDAO error = new ErrorDAO(errorstr);
                throw;
            }
        }

        public void SetOccupied(int tableNr)
        {
            try
            {
                tabledao.SetOccupied(new Table(tableNr));
            }
            catch
            {
                string errorstr = "Chapeau App couldn't set the tables";
                ErrorDAO error = new ErrorDAO(errorstr);
                throw;
            }
        }

        public void SetNoOccupied(Table table)
        {
            try
            {
                tabledao.SetNoOccupied(table);

            }
            catch
            {
                string errorstr = "Chapeau App couldn't set the tables";
                ErrorDAO error = new ErrorDAO(errorstr);
                throw;
            }
        }

        public void SetNoOccupied(int tableNr) // Required method overload for order part of the application.
        {
            try
            {
                tabledao.SetNoOccupied(new Table(tableNr));
            }
            catch
            {
                string errorstr = "Chapeau App couldn't set the tables";
                ErrorDAO error = new ErrorDAO(errorstr);
                throw;
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
                throw;
            }
        }
    }
}
