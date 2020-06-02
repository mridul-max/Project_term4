using System.Collections.Generic;
using ChapeauDAL;
using ChapeauModel;

namespace ChapeauLogic
{
    public class MenuItemService
    {
        MenuItemDAO DAO = new MenuItemDAO();

        public List<MenuItem> GetMenuItems()
        { 
            //I added try catch to your section I hope you don't mind this change. I appreciate it if you double check.
            
            try
            {
                return DAO.GetCompleteMenu();
            }
            catch
            {
                string errorstr = "Chapeau App couldn't get the menu items.";
                ErrorDAO error = new ErrorDAO(errorstr);
                throw;
            }
            
        }
        public void CreateMenuItem(MenuItem item)
        {
            DAO.CreateMenuItem(item);
        }
        public void DeleteMenuItem(MenuItem item)
        {
            DAO.DeleteMenuItem(item);
        }
        public void UpdateStockOfItem(MenuItem item)
        {
            DAO.UpdateStockOfItem(item);
        }
        public MenuItem GetById(int id)
        {
            return DAO.GetById(id);
        }


        //example of returned format: Dinner > Mains > Pizza
        //code example: sortedMenu["Dinner"]["Mains"][3]

        public Dictionary<string, Dictionary<string, List<MenuItem>>> GetSortedMenu()
        {
            List<MenuItem> unsortedMenu = GetMenuItems();
            Dictionary < string, Dictionary<string, List<MenuItem>>> sortedMenu = new Dictionary<string, Dictionary<string, List<MenuItem>>>();

            foreach (var menuItem in unsortedMenu)
            {
                string categoryType = menuItem.CategoryType.ToString();

                if (!sortedMenu.ContainsKey(categoryType))
                {
                    sortedMenu.Add(categoryType, new Dictionary<string, List<MenuItem>>());
                }
                if (!sortedMenu[categoryType].ContainsKey(menuItem.Category))
                {
                    sortedMenu[categoryType].Add(menuItem.Category, new List<MenuItem>());
                }
                sortedMenu[categoryType][menuItem.Category].Add(menuItem);
            }
            return sortedMenu;
        }
    }
}
