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
            return DAO.GetCompleteMenu();
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
