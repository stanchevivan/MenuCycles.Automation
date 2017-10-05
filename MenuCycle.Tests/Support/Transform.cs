using TechTalk.SpecFlow;
using System;
using System.Collections.Generic;
using MenuCycle.Data;
using MenuCycle.Data.Repositories;
using MenuCycle.Data.Services;
using System.Linq;
using MenuCycle.Data.Generators;
using MenuCycle.Data.Models;

namespace MenuCycle.Tests.Support
{
    [Binding]
    public class Transform
    {
        private ScenarioContext context;
        private MenuCycleGenerator menuCycleGenerator;
        public Transform(ScenarioContext context, MenuCycleGenerator menuCycleGenerator)
        {
            this.context = context;
            this.menuCycleGenerator = menuCycleGenerator;
        }

        /// <summary>
        /// Creates a list of Menu Cycles based on a table passed through the steps
        /// </summary>
        /// <param name="table">The table from feature step</param>
        /// <returns></returns>
        [StepArgumentTransformation]
        public IList<MenuCycles> MenuCyclesList(Table table)
        {
            IList<MenuCycles> menuCycleList = this.menuCycleGenerator.Generate(table.RowCount).ToList();

            IList<Groups> groupList = new List<Groups>();
            GroupRepository groupRepository = new GroupRepository();

            foreach (TableRow row in table.Rows)
            {
                menuCycleList.ToList().ForEach(m => ReplaceWithTable(m, row));
                if (row.ContainsKey("Group"))
                {
                    groupList.Add(groupRepository.FindByName(row["Group"]));
                }
            }
            context.Set(groupList);
            context.Set(menuCycleList);

            return menuCycleList;
        }

        /// <summary>
        /// Replaces the value from a menu cycle object with the ones set in the table from steps
        /// </summary>
        /// <param name="menu">The Menu Cycle object</param>
        /// <param name="row">The row to search for the value replacements</param>
        /// <returns>A modified menu cycle object</returns>
        private static MenuCycles ReplaceWithTable(MenuCycles menu, TableRow row)
        {
            foreach (var item in row.Keys)
            {
                var propInfo = menu.GetType().GetProperty(item);

                if (propInfo != null)
                {
                    var value = Convert.ChangeType(row[item], propInfo.PropertyType);
                    menu.GetType().GetProperty(item).SetValue(menu, value);
                }
            }

            return menu;
        }
    }
}

