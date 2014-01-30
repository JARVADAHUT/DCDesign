using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns___DC_Design
{
    abstract class DungeonCharacter
    {
        GearSet _gearInfo;
        string name;
        Stats dcStats;

        List<ICombatAction> combatActions;
        Inventory inventory;
    }
}
