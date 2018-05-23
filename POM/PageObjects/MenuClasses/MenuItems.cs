using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.POM.PageObjects.MenuClasses
{
    class MenuItems
    {
        public InteractionsMenu interactionMenu;
        public MainMenu mainMenu;
        public WidgetMenu widgetMenu;
        public DraggableSubMenu draggableSubMenu;

        public MenuItems()
        {
            interactionMenu = new InteractionsMenu();
            mainMenu = new MainMenu();
            widgetMenu = new WidgetMenu();
            draggableSubMenu = new DraggableSubMenu();
        }
    }
}
