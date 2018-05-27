using AutomationFramework.SupportLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.POM.PageObjects.MenuClasses
{
    class MenuItems:DriverClass
    {
        public InteractionsMenu interactionMenu;
        public MainMenu mainMenu;
        public WidgetMenu widgetMenu;
        //public DraggableSubMenu draggableSubMenu;

        public MenuItems()
        {
            interactionMenu = new InteractionsMenu(dr);
            mainMenu = new MainMenu(dr);
            widgetMenu = new WidgetMenu(dr);
           // draggableSubMenu = new DraggableSubMenu(dr);
        }
    }
}
