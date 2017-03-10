#region

using wServer.logic.behaviors;
using wServer.logic.loot;
using System;
using wServer.logic.transitions;

#endregion

namespace wServer.logic
{
    partial class BehaviorDb
    {
        private _ IvoryDragon = () => Behav()
        .Init("Lod Ivory Wyvern",
            new State(
                new State("1"
                    )
                )
            )
        ;
    }
}