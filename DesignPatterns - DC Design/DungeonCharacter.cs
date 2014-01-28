using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns___DC_Design
{
    abstract class DungeonCharacter
    {
        int _maxHP, _curHp;
        int _maxResources, _curResources;
        GearSet _gearInfo;
        string name;

        List<ICombatAction> combatActions;
    }
}
