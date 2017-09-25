using TechTalk.SpecFlow;
using System;
using System.Collections.Generic;
using MenuCycleData;
using MenuCycleData.Repositories;

namespace MenuCycles.AutomatedTests.Hooks
{
    [Binding]
    public class Transform
    {
        private Seeding seed;
        private ScenarioContext context;
        public Transform(Seeding seed, ScenarioContext context)
        {
            this.seed = seed;
            this.context = context;
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

            List<Group> glist = new List<Group>();
            GroupRepository gRepository = new GroupRepository();

            foreach (TableRow row in table.Rows)
            {
                list.Add(ReplaceWithTable(this.seed.GenerateMenuCycle(), row));

                if (row.ContainsKey("Group"))
                {
                    glist.Add(gRepository.FindByName(row["Group"]));
                }
            }

            context.Set(glist);
            context.Set(list);

            return list;
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

