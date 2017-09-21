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

        /// <summary>
        /// Creates a list of Menu Cycles based on a table passed through the steps
        /// </summary>
        /// <param name="table">The table from feature step</param>
        /// <returns></returns>
        [StepArgumentTransformation]
        public List<MenuCycle> MenuCyclesList(Table table)
        {
            List<MenuCycle> list = new List<MenuCycle>();
            foreach (TableRow row in table.Rows)
            {
                list.Add(ReplaceWithTable(this.seed.GenerateMenuCycle(), row));
            }

            return list;
        }

        /// <summary>
        /// Creates a single Menu Cycle based on a table passed through the steps
        /// </summary>
        /// <param name="table">The table from feature step</param>
        /// <returns></returns>
        [StepArgumentTransformation]
        public MenuCycle SingleMenuCycle(Table table)
        {
            if (table.RowCount > 1)
            {
                throw new Exception("Table should contain only one row");
            }
            
            return ReplaceWithTable(this.seed.GenerateMenuCycle(), table.Rows[0]); 
        }

        /// <summary>
        /// This replaces the value from a menu cycle object with the ones set in the table from steps
        /// </summary>
        /// <param name="menu">The Menu Cycle object</param>
        /// <param name="row">The row to search for the value replacements</param>
        /// <returns>A modified menu cycle object</returns>
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

