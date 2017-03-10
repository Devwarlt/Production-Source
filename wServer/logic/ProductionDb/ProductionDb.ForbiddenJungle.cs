using wServer.logic.behaviors;
using wServer.logic.transitions;
using wServer.logic.loot;
using wServer.logic.CustomBehaviorsTransitions;

namespace wServer.logic
{
    partial class BehaviorDb
    {
        private _ ForbiddenJungle = () => Behav()
            .Init("Great Temple Snake",
                new State(
                    new Prioritize(
                        new Follow(0.6),
                        new Wander(0.4)
                        ),
                    new Shoot(10, 2, 7, 0, coolDown: 1000, coolDownOffset: 0),
                    new Shoot(10, 6, 60, 1, coolDown: 2000, coolDownOffset: 600)
                    )
            )
            .Init("Great Snake Egg",
                new State(
                    new TransformOnDeath("Great Temple Snake", 1, 2),
                    new State("Wait",
                        new TimedTransition(2500, "Explode"),
                        new PlayerWithinTransition(2, "Explode")
                        ),
                    new State("Explode",
                        new Suicide()
                        )
                    )
            )
            .Init("Great Coil Snake",
                new State(
                    new DropPortalOnDeath("Forbidden Jungle Portal", 20),
                    new Prioritize(
                        new StayCloseToSpawn(0.8, 5),
                        new Wander(0.4)
                        ),
                    new State("Waiting",
                        new PlayerWithinTransition(15, "Attacking")
                        ),
                    new State("Attacking",
                        new Shoot(10, projectileIndex: 0, coolDown: 700, coolDownOffset: 600),
                        new Shoot(10, 10, 36, 1, coolDown: 2000),
                        new TossObject("Great Snake Egg", 4, 0, 5000, coolDownOffset: 0),
                        new TossObject("Great Snake Egg", 4, 90, 5000, 600),
                        new TossObject("Great Snake Egg", 4, 180, 5000, 1200),
                        new TossObject("Great Snake Egg", 4, 270, 5000, 1800),
                        new NoPlayerWithinTransition(30, "Waiting")
                        )
                    )
            )
            .Init("Mixcoatl the Masked God",
                new State(
                    new TransformOnDeath("Realm Portal", returnToSpawn: true),
                    new State("1",
                    new Prioritize(
                        new StayCloseToSpawn(0.6, 6),
                        new Wander(0.4)
                        ),
                    new HpLessTransition(0.99, "Dancing")
                    ),
                    new State("Dancing",
                        new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                        new State("2",
                            new ReturnToSpawn(once: true, speed: 1),
                            new SetAltTexture(3),
                            new TimedTransition(100, "3")
                            ),
                        new State("3",
                            new SetAltTexture(4),
                            new TimedTransition(200, "4")
                            ),
                        new State("4",
                            new SetAltTexture(5),
                            new TimedTransition(200, "5")
                            ),
                        new State("5",
                            new SetAltTexture(6),
                            new TimedTransition(200, "6")
                            ),
                        new State("6",
                            new SetAltTexture(3),
                            new TimedTransition(200, "7")
                            ),
                        new State("7",
                            new SetAltTexture(4),
                            new TimedTransition(200, "8")
                            ),
                        new State("8",
                            new SetAltTexture(5),
                            new TimedTransition(200, "9")
                            ),
                        new State("9",
                            new SetAltTexture(6),
                            new OrderOnce(99, "Boss Totem", "spawn"),
                            new TimedTransition(200, "10")
                            ),
                        new State("10",
                            new SetAltTexture(3),
                            new TimedTransition(200, "11")
                            ),
                        new State("11",
                            new SetAltTexture(4),
                            new TimedTransition(200, "12")
                            ),
                        new State("12",
                            new SetAltTexture(5),
                            new TimedTransition(200, "13")
                            ),
                        new State("13",
                            new SetAltTexture(6),
                            new TimedTransition(200, "14")
                            ),
                        new State("14",
                            new SetAltTexture(3),
                            new TimedTransition(200, "15")
                            ),
                        new State("15",
                            new SetAltTexture(4),
                            new TimedTransition(200, "16")
                            ),
                        new State("16",
                            new SetAltTexture(5),
                            new TimedTransition(200, "17")
                            ),
                        new State("17",
                            new SetAltTexture(6),
                            new OrderOnce(99, "Boss Totem", "spawn2"),
                            new TimedTransition(200, "18")
                            ),
                        new State("18",
                            new SetAltTexture(3),
                            new TimedTransition(200, "Attack")
                            )
                        ),
                    new State("Attack",
                        new Prioritize(
                            new Wander(0.3),
                            new StayCloseToSpawn(0.6, 4)
                            ),
                        new SetAltTexture(0),
                        new HpLessTransition(0.6, "RingAttack"),
                        new State("19", //Start Circling
                            new Shoot(99, 3, 15, projectileIndex: 1, fixedAngle: 0, angleOffset: 90, coolDown: 99999),
                            new TimedTransition(300, "20")
                            ),
                        new State("20",
                            new Shoot(99, 3, 15, projectileIndex: 1, fixedAngle: 0, angleOffset: 135, coolDown: 99999),
                            new TimedTransition(300, "21")
                            ),
                        new State("21",
                            new Shoot(99, 3, 15, projectileIndex: 1, fixedAngle: 0, angleOffset: 180, coolDown: 99999),
                            new TimedTransition(300, "22")
                            ),
                        new State("22",
                            new Shoot(99, 3, 15, projectileIndex: 1, fixedAngle: 0, angleOffset: 225, coolDown: 99999),
                            new TimedTransition(300, "23")
                            ),
                        new State("23",
                            new Shoot(99, 3, 15, projectileIndex: 1, fixedAngle: 0, angleOffset: 270, coolDown: 99999),
                            new TimedTransition(300, "24")
                            ),
                        new State("24",
                            new Shoot(99, 3, 15, projectileIndex: 1, fixedAngle: 0, angleOffset: 315, coolDown: 99999),
                            new TimedTransition(300, "25")
                            ),
                        new State("25",
                            new Shoot(99, 3, 15, projectileIndex: 1, fixedAngle: 0, angleOffset: 0, coolDown: 99999),
                            new TimedTransition(300, "26")
                            ),
                        new State("26",
                            new Shoot(99, 3, 15, projectileIndex: 1, fixedAngle: 0, angleOffset: 45, coolDown: 99999),
                            new TimedTransition(300, "19")
                            )
                        ),
                    new State("RingAttack",
                        new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                        new ReturnToSpawn(once: true, speed: 1),
                        new Shoot(99, 8, 45, projectileIndex: 0, fixedAngle: 0, angleOffset: 45, coolDown: 750),
                        new TimedTransition(2500, "Rage"),
                            new State("29",
                                new OrderOnce(99, "Boss Totem", "spawn3"),
                                new TimedTransition(200, "27")
                                ),
                            new State("27",
                                new SetAltTexture(1),
                                new TimedTransition(200, "28")
                                ),
                            new State("28",
                                new SetAltTexture(2),
                                new TimedTransition(200, "27")
                                )
                        ),
                    new State("Rage",
                        new Follow(0.4, 20, 3),
                        new StayCloseToSpawn(0.7, 13),
                        new SetAltTexture(0),
                        new Order(99, "Boss Totem", "shoot3"),
                        new Shoot(10, 1, projectileIndex: 2, coolDown: 750),
                        new State("r1", //Start Circling 2
                            new Shoot(99, 3, 15, projectileIndex: 1, fixedAngle: 0, angleOffset: 90, coolDown: 99999),
                            new TimedTransition(300, "r2")
                            ),
                        new State("r2",
                            new Shoot(99, 3, 15, projectileIndex: 1, fixedAngle: 0, angleOffset: 135, coolDown: 99999),
                            new TimedTransition(300, "r3")
                            ),
                        new State("r3",
                            new Shoot(99, 3, 15, projectileIndex: 1, fixedAngle: 0, angleOffset: 180, coolDown: 99999),
                            new TimedTransition(300, "r4")
                            ),
                        new State("r4",
                            new Shoot(99, 3, 15, projectileIndex: 1, fixedAngle: 0, angleOffset: 225, coolDown: 99999),
                            new TimedTransition(300, "r5")
                            ),
                        new State("r5",
                            new Shoot(99, 3, 15, projectileIndex: 1, fixedAngle: 0, angleOffset: 270, coolDown: 99999),
                            new TimedTransition(300, "r6")
                            ),
                        new State("r6",
                            new Shoot(99, 3, 15, projectileIndex: 1, fixedAngle: 0, angleOffset: 315, coolDown: 99999),
                            new TimedTransition(300, "r7")
                            ),
                        new State("r7",
                            new Shoot(99, 3, 15, projectileIndex: 1, fixedAngle: 0, angleOffset: 0, coolDown: 99999),
                            new TimedTransition(300, "r8")
                            ),
                        new State("r8",
                            new Shoot(99, 3, 15, projectileIndex: 1, fixedAngle: 0, angleOffset: 45, coolDown: 99999),
                            new TimedTransition(300, "r1")
                            )
                        )
                    ),
                new Threshold(0.01,
                    new ItemLoot("Pollen Powder", 0.5),
                    new ItemLoot("Pollen Powder", 0.5),
                    new TierLoot(5, ItemType.Weapon, 0.2),
                    new TierLoot(6, ItemType.Weapon, 0.1),
                    new TierLoot(5, ItemType.Armor, 0.2),
                    new TierLoot(6, ItemType.Armor, 0.1),
                    new ItemLoot("Staff of the Crystal Serpent", 0.05),
                    new ItemLoot("Robe of the Tlatoani", 0.05),
                    new ItemLoot("Cracked Crystal Skull", 0.05),
                    new ItemLoot("Crystal Bone Ring", 0.05),
                    new ItemLoot("Wine Cellar Incantation", 0.01)
                    )
            )
        .Init("Boss Totem",
            new State(
                new ConditionalEffect(ConditionEffectIndex.Invincible),
                new EntityNotExistsTransition("Mixcoatl the Masked God", 99, "1"),
                new State("1"),
                new State("spawn",
                    new Spawn("Totem Spirit", maxChildren: 1)
                    ),
                new State("spawn2",
                    new Spawn("Totem Spirit", maxChildren: 1)
                    ),
                new State("spawn3",
                    new Spawn("Totem Spirit", maxChildren: 2),
                    new TimedTransition(100, "shoot1")
                    ),
                new State("shoot1",
                    new Shoot(99, 6, shootAngle: 60, projectileIndex: 0, fixedAngle: 0, coolDown: 9999),
                    new TimedTransition(400, "shoot2")
                    ),
                new State("shoot2",
                    new Shoot(99, 6, shootAngle: 60, projectileIndex: 0, fixedAngle: 0, angleOffset: 90, coolDown: 9999),
                    new TimedTransition(400, "shoot1")
                    ),
                new State("shoot3",
                    new EntityNotExistsTransition("Mixcoatl the Masked God", 99, "1"),
                    new State("shoot4",
                        new Shoot(99, 6, shootAngle: 60, projectileIndex: 0, fixedAngle: 0, coolDown: 9999),
                        new TimedTransition(2000, "shoot5")
                        ),
                    new State("shoot5",
                        new Shoot(99, 6, shootAngle: 60, projectileIndex: 0, fixedAngle: 0, angleOffset: 90, coolDown: 9999),
                        new TimedTransition(2000, "shoot4")
                        )
                    )
                )
            )
            .Init("Totem Spirit",
                new State(
                    new Prioritize(
                        new Wander(0.3)
                        ),
                    new Shoot(10, 2, 10, 0, coolDown: 1000)
                    ),
                new Threshold(0.01,
                    new ItemLoot("Magic Potion", 0.1)
                    )
            )
            .Init("Jungle Totem",
                new State(
                    new Spawn("Totem Spirit", maxChildren: 8),
                    new Shoot(10, 9, 10, 0, coolDown: 1500)
                    ),
                new Threshold(0.01,
                    new ItemLoot("Pollen Powder", 0.2),
                    new ItemLoot("Heartstealer Skull", 0.1)
                    )
            )
            .Init("Basilisk Baby",
                new State(
                    new Prioritize(
                        new StayBack(0.5, 4),
                        new Wander(0.4)
                        ),
                    new Shoot(10, 1, projectileIndex: 0, coolDown: 1000)
                    ),
                new Threshold(0.01,
                    new ItemLoot("Basilisk Hide Armor", 0.1)
                    )
            )
            .Init("Basilisk",
                new State(
                    new Prioritize(
                        new StayBack(0.5, 4),
                        new Wander(0.4)
                        ),
                    new Shoot(10, 1, projectileIndex: 1, coolDown: 1000),
                    new Shoot(10, 1, projectileIndex: 2, coolDown: 1000),
                    new Shoot(10, 1, projectileIndex: 3, coolDown: 1000)
                    ),
                new Threshold(0.01,
                    new ItemLoot("Basilisk Hide Armor", 0.1),
                    new ItemLoot("Pollen Powder", 0.2)
                    )
            )
            .Init("Mask Shaman",
                new State(
                    new Prioritize(
                        new Orbit(0.6, 2, target: "Jungle Fire"),
                        new Wander(0.4)
                        ),
                    new Shoot(10, 8, angleOffset: 45, projectileIndex: 0, coolDown: 500)
                    ),
                new Threshold(0.01,
                    new ItemLoot("Pollen Powder", 0.2)
                    )
            )
            .Init("Mask Warrior",
                new State(
                    new Prioritize(
                        new Orbit(0.6, 5, target: "Jungle Fire"),
                        new Wander(0.4),
                        new Follow(0.6, 10, 1)
                        ),
                    new StayCloseToSpawn(0.7, 6),
                    new Shoot(10, 8, angleOffset: 45, projectileIndex: 0, coolDown: 500)
                    ),
                new Threshold(0.01,
                    new ItemLoot("Pollen Powder", 0.2)
                    )
            )
            .Init("Mask Hunter",
                new State(
                    new Prioritize(
                        new Orbit(0.6, 4, target: "Jungle Fire"),
                        new Wander(0.4),
                        new Follow(0.6, 10, 1)
                        ),
                    new StayCloseToSpawn(0.7, 6),
                    new Shoot(10, 1, projectileIndex: 0, coolDown: 500)
                    ),
                new Threshold(0.01,
                    new ItemLoot("Pollen Powder", 0.2)
                    )
            )
            .Init("Jungle Fire",
                new State(
                    new State("1",
                        new Shoot(10, 1, projectileIndex: 1, coolDownOffset: 250, coolDown: 999999),
                        new Shoot(10, 1, projectileIndex: 1, coolDownOffset: 500, coolDown: 999999),
                        new Shoot(10, 1, projectileIndex: 1, coolDownOffset: 750, coolDown: 999999),
                        new Shoot(10, 1, projectileIndex: 1, coolDownOffset: 1000, coolDown: 999999),
                        new Shoot(10, 1, projectileIndex: 1, coolDownOffset: 1250, coolDown: 999999),
                        new Shoot(10, 1, projectileIndex: 1, coolDownOffset: 1500, coolDown: 999999),
                        new Shoot(10, 1, projectileIndex: 1, coolDownOffset: 1750, coolDown: 999999),
                        new Shoot(10, 1, projectileIndex: 1, coolDownOffset: 2000, coolDown: 999999),
                        new Shoot(10, 1, projectileIndex: 1, coolDownOffset: 2250, coolDown: 999999),
                        new Shoot(10, 1, projectileIndex: 1, coolDownOffset: 2500, coolDown: 999999),
                        new TimedTransition(2500, "2")
                        ),
                    new State("2",
                        new TimedTransition(2500, "1")
                        )
                    ),
                    new Threshold(0.01,
                        new TierLoot(5, ItemType.Weapon, 0.13)
                        )
            );


    }
}