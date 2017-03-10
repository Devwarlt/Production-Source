using wServer.logic.behaviors;
using wServer.logic.loot;
using wServer.logic.transitions;
using wServer.logic.CustomBehaviorsTransitions;

namespace wServer.logic
{
    partial class BehaviorDb
    {
        private _ PuppetMaster = () => Behav()
            .Init("The Puppet Master",
                new State(
                    new TransformOnDeath("Puppet Loot Chest"),
                    new State("1",
                        new ConditionalEffect(ConditionEffectIndex.Invulnerable, true),
                        new PlayerWithinTransition(4, "2") //test
                        ),
                    new State("2",
                        new Taunt(true, "Welcome to the Final Act, my friends. My puppets require life essence in order to continue performing..."),
                        new TimedTransition(4000, "3")
                        ),
                    new State("3",
                        new MoveTo(0, 7f, 0.5, true, false, false),
                        new TimedTransition(4000, "4")
                        ),
                    new State("4",
                        new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                        new Taunt("Its not much, but your lives will have to do for now!"),
                        new Flash(0xFFFFFF, 0.3, 12),
                        new TimedTransition(4000, "5")
                        ),
                    new State("5",
                        new ConditionalEffect(ConditionEffectIndex.Armored),
                        new HpLessTransition(0.909, "15"),
                        new State("7",
                            new Shoot(0, 4, 90, 3, 0, 55, coolDown: 999999),
                            new Shoot(0, 4, 90, 3, 0, 35, coolDown: 999999),
                            new TimedTransition(300, "8")
                            ),
                        new State("8",
                            new Shoot(0, 4, 90, 3, 0, 65, coolDown: 999999),
                            new Shoot(0, 4, 90, 3, 0, 25, coolDown: 999999),
                            new TimedTransition(300, "9")
                            ),
                        new State("9",
                            new Shoot(0, 4, 90, 3, 0, 75, coolDown: 999999),
                            new Shoot(0, 4, 90, 3, 0, 15, coolDown: 999999),
                            new TimedTransition(300, "10")
                            ),
                        new State("10",
                            new Shoot(0, 4, 90, 3, 0, 85, coolDown: 999999),
                            new Shoot(0, 4, 90, 3, 0, 5, coolDown: 999999),
                            new TimedTransition(300, "11")
                            ),
                        new State("11",
                            new Shoot(0, 4, 90, 3, 0, 85, coolDown: 999999),
                            new Shoot(0, 4, 90, 3, 0, 5, coolDown: 999999),
                            new TimedTransition(300, "12")
                            ),
                        new State("12",
                            new Shoot(0, 4, 90, 3, 0, 75, coolDown: 999999),
                            new Shoot(0, 4, 90, 3, 0, 15, coolDown: 999999),
                            new TimedTransition(300, "13")
                            ),
                        new State("13",
                            new Shoot(0, 4, 90, 3, 0, 65, coolDown: 999999),
                            new Shoot(0, 4, 90, 3, 0, 25, coolDown: 999999),
                            new TimedTransition(300, "14")
                            ),
                        new State("14",
                            new Shoot(0, 4, 90, 3, 0, 55, coolDown: 999999),
                            new Shoot(0, 4, 90, 3, 0, 35, coolDown: 999999),
                            new TimedTransition(300, "7")
                            )
                        ),
                    new State("15",
                        new HpLessTransition(0.5, "38"),
                        new Follow(0.6, 10, 5),
                        new Shoot(10, 1, projectileIndex: 2, coolDown: 500),
                        new TimedTransition(5000, "16")
                        ),
                    new State("16",
                        new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                        new Taunt("Watch them dance, hero, as they drain your life away!"),
                        new Spawn("Puppet Wizard 2", 1, 0),
                        new Spawn("Puppet Knight 2", 1, 0),
                        new Spawn("Puppet Priest 2", 1, 0),
                        new TimedTransition(4000, "17")
                        ),
                    new State("17",
                        new HpLessTransition(0.5, "38"),
                        new State("18",
                            new Shoot(0, 4, 90, 3, 0, 45, coolDown: 999999),
                            new TimedTransition(300, "19")
                            ),
                        new State("19",
                            new Shoot(0, 4, 90, 3, 0, 55, coolDown: 999999),
                            new TimedTransition(300, "20")
                            ),
                        new State("20",
                            new Shoot(0, 4, 90, 3, 0, 65, coolDown: 999999),
                            new TimedTransition(300, "21")
                            ),
                        new State("21",
                            new Shoot(0, 4, 90, 3, 0, 75, coolDown: 999999),
                            new TimedTransition(300, "22")
                            ),
                        new State("22",
                            new Shoot(0, 4, 90, 3, 0, 85, coolDown: 999999),
                            new TimedTransition(300, "23")
                            ),
                        new State("23",
                            new Shoot(0, 4, 90, 3, 0, 95, coolDown: 999999),
                            new TimedTransition(300, "24")
                            ),
                        new State("24",
                            new Shoot(0, 4, 90, 3, 0, 105, coolDown: 999999),
                            new TimedTransition(300, "25")
                            ),
                        new State("25",
                            new Shoot(0, 4, 90, 3, 0, 115, coolDown: 999999),
                            new TimedTransition(300, "26")
                            ),
                        new State("26",
                            new Shoot(0, 4, 90, 3, 0, 125, coolDown: 999999),
                            new TimedTransition(300, "27")
                            ),
                        new State("27",
                            new Shoot(0, 4, 90, 3, 0, 135, coolDown: 999999),
                            new TimedTransition(300, "28")
                            ),
                        new State("28",
                            new Shoot(0, 4, 90, 3, 0, 125, coolDown: 999999),
                            new TimedTransition(300, "29")
                            ),
                        new State("29",
                            new Shoot(0, 4, 90, 3, 0, 135, coolDown: 999999),
                            new TimedTransition(300, "30")
                            ),
                        new State("30",
                            new Shoot(0, 4, 90, 3, 0, 145, coolDown: 999999),
                            new TimedTransition(300, "31")
                            ),
                        new State("31",
                            new Shoot(0, 4, 90, 3, 0, 155, coolDown: 999999),
                            new TimedTransition(300, "32")
                            ),
                        new State("32",
                            new Shoot(0, 4, 90, 3, 0, 165, coolDown: 999999),
                            new TimedTransition(300, "33")
                            ),
                        new State("33",
                            new Shoot(0, 4, 90, 3, 0, 175, coolDown: 999999),
                            new TimedTransition(300, "34")
                            ),
                        new State("34",
                            new Shoot(0, 4, 90, 3, 0, 185, coolDown: 999999),
                            new TimedTransition(300, "35")
                            ),
                        new State("35",
                            new Shoot(0, 4, 90, 3, 0, 195, coolDown: 999999),
                            new TimedTransition(300, "36")
                            ),
                        new State("36",
                            new Shoot(0, 4, 90, 3, 0, 205, coolDown: 999999),
                            new TimedTransition(300, "37")
                            ),
                        new State("37",
                            new Shoot(0, 4, 90, 3, 0, 215, coolDown: 999999),
                            new TimedTransition(300, "15")
                            )
                        ),
                    new State("38",
                        new Wander(0.3),
                        new HpLessTransition(0.3, "43"),
                        new State("39",
                            new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                            new SetAltTexture(1),
                            new Spawn("False Puppet Master", 5, 0),
                            new Taunt("Find me if you can hero, or die trying!"),
                            new TimedTransition(3000, "40")
                            ),
                        new State("40",
                            new SetAltTexture(0),
                            new Shoot(10, 6, 60, 0, coolDown: 4500),
                            new Shoot(10, 3, 10, 2, coolDown: 3000),
                            new State("41",
                                new ConditionalEffect(ConditionEffectIndex.Armored),
                                new TimedTransition(4000, "42")
                                ),
                            new State("42",
                                new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                                new TimedTransition(4000, "41")
                                )
                            )
                        ),
                    new State("43",
                        new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                        new Taunt("Lucky guess hero, but I've run out of time to play games with you. It is time that you died!"),
                        new ReturnToSpawn(true, 0.8),
                        new Flash(0xFFFFFF, 0.3, 12),
                        new TimedTransition(5000, "44")
                        ),
                    new State("44",
                        new HpLessTransition(0.1545, "52"),
                        new ConditionalEffect(ConditionEffectIndex.Armored),
                        new RemoveEntity(99, "False Puppet Master"),
                        new Spawn("Puppet Wizard 2", 1, 0, 10000),
                        new Spawn("Puppet Knight 2", 1, 0, 10000),
                        new Spawn("Puppet Priest 2", 1, 0, 10000),
                        new State("45",
                            new Shoot(0, 4, 90, 3, 0, 65, coolDown: 999999),
                            new Shoot(0, 4, 90, 3, 0, 25, coolDown: 999999),
                            new TimedTransition(300, "46")
                            ),
                        new State("46",
                            new Shoot(0, 4, 90, 3, 0, 75, coolDown: 999999),
                            new Shoot(0, 4, 90, 3, 0, 15, coolDown: 999999),
                            new TimedTransition(300, "47")
                            ),
                        new State("47",
                            new Shoot(0, 4, 90, 3, 0, 85, coolDown: 999999),
                            new Shoot(0, 4, 90, 3, 0, 5, coolDown: 999999),
                            new TimedTransition(300, "48")
                            ),
                        new State("48",
                            new Shoot(0, 4, 90, 3, 0, 85, coolDown: 999999),
                            new Shoot(0, 4, 90, 3, 0, 5, coolDown: 999999),
                            new TimedTransition(300, "49")
                            ),
                        new State("49",
                            new Shoot(0, 4, 90, 3, 0, 75, coolDown: 999999),
                            new Shoot(0, 4, 90, 3, 0, 15, coolDown: 999999),
                            new TimedTransition(300, "50")
                            ),
                        new State("50",
                            new Shoot(0, 4, 90, 3, 0, 65, coolDown: 999999),
                            new Shoot(0, 4, 90, 3, 0, 25, coolDown: 999999),
                            new TimedTransition(300, "51")
                            ),
                        new State("51",
                            new Shoot(0, 4, 90, 3, 0, 55, coolDown: 999999),
                            new Shoot(0, 4, 90, 3, 0, 35, coolDown: 999999),
                            new TimedTransition(300, "45")
                            )
                        ),
                    new State("52",
                        new ConditionalEffect(ConditionEffectIndex.Invulnerable, true),
                        new Taunt("No!!! This can not be how my story ends!! I WILL HAVE MY ENCORE, HERO!"),
                        new TimedTransition(5000, "53")
                        ),
                    new State("53",
                        new Shoot(0, 10, 36, 1, 0, 0, coolDown: 999999),
                        new Suicide()
                        )
                    )
            )
            .Init("Puppet Wizard 2",
                new State(
                    new Follow(0.6, 10, 3),
                    new Shoot(9, 15, 24, 0, coolDown: 2500)
                 )
          )
            .Init("Puppet Knight 2",
                new State(
                    new Follow(0.6, 10, 3),
                    new Shoot(9, count: 1, projectileIndex: 0, coolDown: 1750),
                    new Shoot(9, count: 1, projectileIndex: 1, coolDown: 2000)
                 )
          )
            .Init("Puppet Knight",
                new State(
                    new Follow(0.6, 10, 3),
                    new Shoot(9, count: 1, projectileIndex: 0, coolDown: 1750),
                    new Shoot(9, count: 1, projectileIndex: 1, coolDown: 2000)
                 )
          )
            .Init("Puppet Priest 2",
                new State(
                    new Orbit(0.37, 4, 20, "The Puppet Master"),
                    new HealEntity(99, "The Puppet Master", 75, 4500),
                    new State("text0",
                        new SetAltTexture(0),
                        new TimedTransition(500, "text1")
                        ),
                    new State("text1",
                        new SetAltTexture(1),
                        new TimedTransition(500, "text2")
                        ),
                    new State("text2",
                        new SetAltTexture(2),
                        new TimedTransition(500, "text3")
                        ),
                    new State("text3",
                        new SetAltTexture(3),
                        new TimedTransition(500, "text4")
                        ),
                    new State("text4",
                        new SetAltTexture(4),
                        new TimedTransition(500, "text0")
                        )
                 )
          )
            .Init("Healer Puppet",
                new State(
                    new Follow(0.4, 10, 3),
                    new Shoot(8.4, count: 1, projectileIndex: 0, coolDown: 1250)
                 )
          )
            .Init("False Puppet Master",
                new State(
                    new TransformOnDeath("Rogue Puppet", 1, 1, 1),
                    new TransformOnDeath("Assassin Puppet", 1, 1, 1),
                    new State(
                        new Wander(0.4),
                        new Protect(1, "The Puppet Master", 10, 8, 3),
                        new Shoot(8.4, count: 7, projectileIndex: 0, coolDown: 2850),
                        new Shoot(8.4, count: 3, shootAngle: 30, projectileIndex: 2, coolDown: 3500),
                        new HpLessTransition(0.11, "dead")
                        ),
                     new State("dead",
                        new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                        new Taunt(1.00, "You may have killed me, but I am only a pretender. Get ready for the plot twist!"),
                        new TimedTransition(2500, "die")
                        ),
                     new State("die",
                         new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                         new Shoot(8.4, count: 8, projectileIndex: 1, coolDown: 2850),
                         new Suicide()
                        )
                     )
            )
            .Init("Assassin Puppet",
                new State(
                    new Follow(0.35, 8, 4),
                    new Wander(0.2),
                    new Grenade(3, 140, 4, coolDown: 3000),
                    new Shoot(8.4, count: 1, projectileIndex: 0, coolDown: 1500)
                    )
            )
            .Init("Archer Puppet",
                new State(
                    new Wander(0.42),
                    new Shoot(9, count: 3, projectileIndex: 0, coolDown: 1550),
                    new Shoot(9, count: 1, projectileIndex: 1, coolDown: 2700)
                    )
            )
            .Init("Rogue Puppet",
                new State(
                    new State("1",
                        new SetAltTexture(1),
                        new Wander(0.6),
                        new TimedTransition(3000, "2")
                        ),
                    new State("2",
                        new SetAltTexture(0),
                        new Shoot(9, count: 1, projectileIndex: 0, coolDown: 1000),
                        new TimedTransition(3000, "1")
                        )
                )
            )
            .Init("Warrior Puppet",
                new State(
                    new State("1",
                        new ConditionalEffect(ConditionEffectIndex.Armored),
                        new Wander(0.6),
                        new TimedTransition(4700, "2")
                        ),
                    new State("2",
                        new Shoot(8.4, count: 1, projectileIndex: 0, coolDown: 300),
                        new TimedTransition(4700, "1")
                        )
                    )
            )
            .Init("Paladin Puppet",
                new State(
                    new Follow(0.35, 8, 1),
                    new Wander(0.2),
                    new HealSelf(5000, 80),
                    new Shoot(8.4, count: 1, projectileIndex: 0, coolDown: 1000)
                    )
            )
            .Init("Mystic Puppet",
                new State(
                    new Wander(0.27),
                    new Shoot(9, count: 1, projectileIndex: 0, coolDown: 1350),
                    new Shoot(9, count: 1, projectileIndex: 1, coolDown: 1950)
                    )
            )
            .Init("Sorcerer Puppet",
                new State(
                    new Follow(0.2, 8, 1),
                    new Wander(0.6),
                    new TossObject("Puppet Bomb", 5, coolDown: 7500),
                    new Shoot(8.4, count: 1, projectileIndex: 0, coolDown: 2000)
                    )
            )
            .Init("Puppet Bomb",
                new State(
                    new TransformOnDeath("Sorc Bomb Thrower", 1, 1, 1),
                    new State("1",
                        new TimedTransition(2750, "2")
                    ),
                    new State("2",
                        new Shoot(8.4, count: 1, fixedAngle: 0, projectileIndex: 0, coolDown: 1000),
                        new Shoot(8.4, count: 1, fixedAngle: 90, projectileIndex: 0, coolDown: 1000),
                        new Shoot(8.4, count: 1, fixedAngle: 180, projectileIndex: 0, coolDown: 1000),
                        new Shoot(8.4, count: 1, fixedAngle: 270, projectileIndex: 0, coolDown: 1000),
                        new Shoot(8.4, count: 1, fixedAngle: 45, projectileIndex: 0, coolDown: 1000),
                        new Shoot(8.4, count: 1, fixedAngle: 135, projectileIndex: 0, coolDown: 1000),
                        new Shoot(8.4, count: 1, fixedAngle: 235, projectileIndex: 0, coolDown: 1000),
                        new Shoot(8.4, count: 1, fixedAngle: 315, projectileIndex: 0, coolDown: 1000),
                        new Suicide()
                        )
                )
            )
            .Init("Puppet Bomb 2",
                new State(
                    new State("1",
                        new TimedTransition(2750, "2")
                        ),
                    new State("2",
                        new Shoot(8.4, count: 1, fixedAngle: 0, projectileIndex: 0, coolDown: 1000),
                        new Shoot(8.4, count: 1, fixedAngle: 90, projectileIndex: 0, coolDown: 1000),
                        new Shoot(8.4, count: 1, fixedAngle: 180, projectileIndex: 0, coolDown: 1000),
                        new Shoot(8.4, count: 1, fixedAngle: 270, projectileIndex: 0, coolDown: 1000),
                        new Shoot(8.4, count: 1, fixedAngle: 45, projectileIndex: 0, coolDown: 1000),
                        new Shoot(8.4, count: 1, fixedAngle: 135, projectileIndex: 0, coolDown: 1000),
                        new Shoot(8.4, count: 1, fixedAngle: 235, projectileIndex: 0, coolDown: 1000),
                        new Shoot(8.4, count: 1, fixedAngle: 315, projectileIndex: 0, coolDown: 1000),
                        new Suicide()
                        )
                    )
            )
            .Init("Sorc Bomb Thrower",
                new State(
                    new ConditionalEffect(ConditionEffectIndex.Invincible),
                    new State("throw",
                        new TossObject("Puppet Bomb 2", 5, angle: 135, coolDown: 1500),
                        new TossObject("Puppet Bomb 2", 5, angle: 60, coolDown: 1500),
                        new TimedTransition(1000, "die")
                        ),
                    new State("die",
                        new Suicide()
                        )
                    )
            )
            .Init("Trickster Puppet",
                new State(
                    new Shoot(8.4, count: 1, projectileIndex: 0, coolDown: 1300),
                    new State("wait",
                        new Wander(0.3),
                        new PlayerWithinTransition(6, "start")
                        ),
                    new State("start",
                        new Reproduce("Trickster Decoys", densityMax: 1, densityRadius: 1, spawnRadius: 1, coolDown: 5250),
                        new Wander(0.6),
                        new StayBack(0.3, 3)
                        )
                    )
            )
            .Init("Trickster Decoys",
                new State(
                    new Wander(0.31),
                    new Shoot(8.4, count: 1, projectileIndex: 0, coolDown: 1400)
                    )
            )
            .Init("Oryx Puppet",
                new State(
                    new TransformOnDeath("Puppet Treasure Chest"),
                    new State("1",
                        new ConditionalEffect(ConditionEffectIndex.Invulnerable, true),
                        new PlayerWithinTransition(4, "2")
                        ),
                    new State("2",
                        new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                        new Taunt(true, "Am I not an uncanny likeness to Oryx himself?"),
                        new TimedTransition(4000, "3")
                        ),
                    new State("3",
                        new HpLessTransition(0.7, "5"),
                        new Taunt("You don’t see the similarity? Well then, let me show you!"),
                        new TimedTransition(4000, "4")
                        ),
                    new State("4",
                        new HpLessTransition(0.7, "5"),
                        new Shoot(10, 8, 10, 0, coolDown: 1500)
                        ),
                    new State("5",
                        new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                        new Spawn("Minion Puppet", 4, 0),
                        new TimedTransition(5000, "6")
                        ),
                    new State("6",
                        new HpLessTransition(0.4, "7"),
                        new Spawn("Minion Puppet", 4, 0),
                        new Swirl(0.8, 3, 10, true),
                        new Grenade(2.7, 120, 5, coolDown: 750),
                        new Shoot(10, 1, projectileIndex: 1, coolDown: 2000)
                        ),
                    new State("7",
                        new ConditionalEffect(ConditionEffectIndex.Invulnerable, true),
                        new Taunt("I may not have all the power of Oryx, but my artifacts should still be enough to kill the likes of you!"),
                        new TossObject("Mini Guardian Element", 1, 0, 90000001, 1000),
                        new TossObject("Mini Guardian Element", 1, 90, 90000001, 1000),
                        new TossObject("Mini Guardian Element", 1, 180, 90000001, 1000),
                        new TossObject("Mini Guardian Element", 1, 270, 90000001, 1000),
                        new TimedTransition(12000, "8")
                        ),
                    new State("8",
                        new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                        new RemoveEntity(999, "Mini Guardian Element"),
                        new TimedTransition(2000, "9")
                        ),
                    new State("9",
                        new HpLessTransition(0.1, "10"),
                        new ConditionalEffect(ConditionEffectIndex.Armored),
                        new Shoot(99, 15, 10, 2, coolDown: 1500)
                        ),
                    new State("10",
                        new ConditionalEffect(ConditionEffectIndex.Invulnerable, true),
                        new Taunt("Nooooo! This cannot be!"),
                        new TimedTransition(4000, "11")
                        ),
                    new State("11",
                        new Suicide()
                        )
                    )
            )
            .Init("Minion Puppet",
                new State(
                    new Wander(0.4),
                    new Shoot(3, 3, 10, 0, coolDown: 1000),
                    new Shoot(3, 3, projectileIndex: 1, shootAngle: 10, coolDown: 1000)
                    )
            )
            .Init("Mini Guardian Element",
                new State(
                    new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                    new Orbit(1, 1, target: "Oryx Puppet", radiusVariance: 0),
                    new Shoot(25, 3, 10, 0, coolDown: 1000)
                    )
            )
            .Init("Puppet Loot Chest",
                new State(
                    new State("Idle",
                        new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                        new TimedTransition(5000, "UnsetEffect")
                    ),
                    new State("UnsetEffect")
                ),
                new MostDamagers(3,
                    new ItemLoot("Potion of Attack", 1)
                    ),
                new Threshold(0.01,
                    new TierLoot(9, ItemType.Weapon, 0.15),
                    new TierLoot(10, ItemType.Weapon, 0.1),
                    new TierLoot(5, ItemType.Ability, 0.07),
                    new TierLoot(11, ItemType.Armor, 0.1),
                    new ItemLoot("Large Jester Argyle Cloth", 0.05),
                    new ItemLoot("Small Jester Argyle Cloth", 0.05),
                    new ItemLoot("Harlequin Armor", 0.01),
                    new ItemLoot("Prism of Dancing Swords", 0.01)
                )
            )
            .Init("Puppet Treasure Chest",
                new State(
                    new State("Idle",
                        new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                        new TimedTransition(5000, "UnsetEffect")
                    ),
                    new State("UnsetEffect")
                ),
                new MostDamagers(1,
                    new ItemLoot("Potion of Attack", 1)
                    ),
                new Threshold(0.01,
                    new TierLoot(9, ItemType.Weapon, 0.15),
                    new TierLoot(10, ItemType.Weapon, 0.1),
                    new TierLoot(5, ItemType.Ability, 0.07),
                    new TierLoot(11, ItemType.Armor, 0.1),
                    new ItemLoot("Large Jester Argyle Cloth", 0.05),
                    new ItemLoot("Small Jester Argyle Cloth", 0.05),
                    new ItemLoot("Prism of Dancing Swords", 0.01)
                )
            )
        ;
    }
}
