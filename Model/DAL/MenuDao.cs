using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;

namespace Model.DAL
{
    public class MenuDao
    {
        public List<Menu> GetMenus()
        {
            var context=new MenuDbContext();
            return context.Menus.ToList();
        }
    }
}
