#region

using wServer.logic.behaviors;
using wServer.logic.loot;
using wServer.logic.transitions;

#endregion

namespace wServer.logic
{
    partial class BehaviorDb
    {
        private _ Beachzone = () => Behav()
            .Init("Masked Party God",
                new State(
                    new Heal(1, "Self", 5000),
                    new Taunt(true, 2500,
                        "Lets have a fun-time in the sun-shine!",
                        "Oh no, Mixcoatl is my brother, I prefer partying to fighting.",
                        "Nothing like relaxin' on the beach.",
                        "Chillin' is the name of the game!",
                        "I hope you're having a good time!",
                        "How do you like my shades?",
                        "EVERYBODY BOOGEY!",
                        "What a beautiful day!",
                        "Whoa there!",
                        "Oh SNAP!",
                        "Ho!"),
                    new State("1",
                        new SetAltTexture(1),
                        new TimedTransition(400, "2")
                    ),
                    new State("2",
                        new SetAltTexture(2),
                        new TimedTransition(400, "3")
                    ),
                    new State("3",
                        new SetAltTexture(3),
                        new TimedTransition(400, "4")
                    ),
                    new State("4",
                        new SetAltTexture(1),
                        new TimedTransition(400, "5")
                    ),
                    new State("5",
                        new SetAltTexture(2),
                        new TimedTransition(400, "6")
                    ),
                    new State("6",
                        new SetAltTexture(3),
                        new TimedTransition(400, "7")
                    ),
                    new State("7",
                        new SetAltTexture(1),
                        new TimedTransition(400, "8")
                    ),
                    new State("8",
                        new SetAltTexture(2),
                        new TimedTransition(400, "9")
                    ),
                    new State("9",
                        new SetAltTexture(3),
                        new TimedTransition(400, "10")
                    ),
                    new State("10",
                        new SetAltTexture(1),
                        new TimedTransition(400, "11")
                    ),
                    new State("11",
                        new SetAltTexture(2),
                        new TimedTransition(400, "end")
                    ),
                    new State("end",
                        new SetAltTexture(3),
                        new TimedTransition(400, "1")
                    )
                ),
                new Threshold(0.01,
                    new ItemLoot("Blue Paradise", 0.25),
                    new ItemLoot("Pink Passion Breeze", 0.25),
                    new ItemLoot("Bahama Sunrise", 0.25),
                    new ItemLoot("Lime Jungle Bay", 0.25)
                )
            );
    }
}