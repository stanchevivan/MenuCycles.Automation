using TechTalk.SpecFlow;
using MenuCyclesData.DatabaseDataModel;
using System;
using System.Collections.Generic;
using MenuCyclesData;
using MenuCyclesData.Helpers;

namespace MenuCycles.AutomatedTests.Hooks
{
    [Binding]
    public class Transform
    {
        private Seeding seed;
        public Transform(Seeding seed)
        {
            this.seed = seed;
        }

        [StepArgumentTransformation]
        public List<MenuCycle> MenuCyclesList(Table table)
        {
            List<MenuCycle> list = new List<MenuCycle>();
            foreach (TableRow row in table.Rows)
            {
                list.Add(this.seed.GenerateMenuCycle());
                //list.Add(GenerateMenuCycle(row));
            }

            return list;
        }

        [StepArgumentTransformation]
        public MenuCycle SingleMenuCycle(Table table)
        {
            if (table.RowCount > 1)
            {
                throw new Exception("Table should contain only one row");
            }
            
            return ReplaceWithTable(this.seed.GenerateMenuCycle(), table.Rows[0]); 
            //return GenerateMenuCycle(table.Rows[0]);
        }

        private static MenuCycle ReplaceWithTable(MenuCycle menu, TableRow row)
        {
            foreach (var item in row.Keys)
            {
                System.Reflection.PropertyInfo propInfo = menu.GetType().GetProperty(item);
                var value = Convert.ChangeType(row[item], propInfo.PropertyType);
                menu.GetType().GetProperty(item).SetValue(menu, value);
            }

            return menu;
        }
    }
}

