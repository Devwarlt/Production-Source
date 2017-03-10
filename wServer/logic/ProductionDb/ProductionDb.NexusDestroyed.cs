using wServer.logic.behaviors;
using wServer.logic.loot;
using wServer.logic.transitions;
using wServer.logic.ProductionBehaviorsTransitions;
using wServer.logic.CustomBehaviorsTransitions;

namespace wServer.logic
{
    partial class BehaviorDb
    {
        private _ NexusDestroyed = () => Behav()
            .Init("destnex Observer 1",
                new State(
                    new ConditionalEffect(ConditionEffectIndex.Invincible),
                    new State("RandomBoss",
                        new TimedRandomTransition(1000, false, "boss1", "boss2")
                        ),
                    new State("boss1",
                        new Spawn("Murderous Megamoth Deux", 1, 0)
                        ),
                    new State("boss2",
                        new Spawn("Lord Ruthven Deux", 1, 0)
                        )
                    )
            )
            .Init("destnex Observer 2",
                new State(
                    new ConditionalEffect(ConditionEffectIndex.Invincible),
                    new State("idle"),
                    new State("RandomBoss",
                        new TimedRandomTransition(1000, false, "boss1", "boss2")
                        ),
                    new State("boss1",
                        new Spawn("Archdemon Malphas Deux", 1, 0)
                        ),
                    new State("boss2",
                        new Spawn("Stheno the Snake Queen Deux", 1, 0)
                        )
                    )
            )
            .Init("destnex Observer 3",
                new State(
                    new ConditionalEffect(ConditionEffectIndex.Invincible),
                    new State("idle"),
                    new State("RandomBoss",
                        new TimedRandomTransition(1000, false, "boss1", "boss2")
                        ),
                    new State("boss1",
                        new Spawn("Golden Oryx Effigy Deux", 1, 0)
                        ),
                    new State("boss2",
                        new Spawn("NM Green Dragon God Deux", 1, 0)
                        )
                    )
            )
            .Init("destnex Observer 4",
                new State(
                    new ConditionalEffect(ConditionEffectIndex.Invincible),
                    new State("idle"),
                    new State("boss1",
                        new Spawn("Oryx the Mad God Deux", 1, 0)
                        )
                    )
            )
            .Init("Oryx the Mad God Deux",
                new State(
                    new DropPortalOnDeath("Realm Portal", 100),
                    new State("Attack",
                        new HpLessTransition(.3, "prepareRage"),
                        new Wander(.05),
                        new Shoot(25, projectileIndex: 0, count: 8, shootAngle: 45, coolDown: 1500),
                        new Shoot(25, projectileIndex: 2, count: 3, shootAngle: 10, coolDown: 1000),
                        new Taunt(1, 6000, "Puny mortals! My {HP} HP will annihilate you!"),
                        new Spawn("Henchman of Oryx", 3, 0),
                        new State("Attack 2",
                            new Shoot(25, projectileIndex: 1, count: 3, shootAngle: 10, coolDown: 999999, coolDownOffset: 400),
                            new Shoot(25, projectileIndex: 3, count: 3, shootAngle: 10, coolDown: 999999, coolDownOffset: 800),
                            new Shoot(25, projectileIndex: 4, count: 3, shootAngle: 10, coolDown: 999999, coolDownOffset: 1200),
                            new Shoot(25, projectileIndex: 5, count: 3, shootAngle: 10, coolDown: 999999, coolDownOffset: 1600),
                            new Shoot(25, projectileIndex: 6, count: 3, shootAngle: 10, coolDown: 999999, coolDownOffset: 2000),
                            new TimedTransition(2000, "Attack 3")
                            ),
                        new State("Attack 3",
                            new Shoot(25, projectileIndex: 1, count: 3, shootAngle: 10, coolDown: 999999, coolDownOffset: 400),
                            new Shoot(25, projectileIndex: 3, count: 3, shootAngle: 10, coolDown: 999999, coolDownOffset: 800),
                            new Shoot(25, projectileIndex: 4, count: 3, shootAngle: 10, coolDown: 999999, coolDownOffset: 1200),
                            new Shoot(25, projectileIndex: 5, count: 3, shootAngle: 10, coolDown: 999999, coolDownOffset: 1600),
                            new Shoot(25, projectileIndex: 6, count: 3, shootAngle: 10, coolDown: 999999, coolDownOffset: 2000),
                            new TimedTransition(2500, "Attack 2")
                            )
                    ),
                    new State("prepareRage",
                        new Follow(.1, 15, 3),
                        new Taunt("Can't... keep... henchmen... alive... anymore! ARGHHH!!!"),
                        new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                        new Shoot(25, 30, fixedAngle: 0, projectileIndex: 7, coolDown: 4000, coolDownOffset: 4000),
                        new Shoot(25, 30, fixedAngle: 30, projectileIndex: 8, coolDown: 4000, coolDownOffset: 5000),
                        new Shoot(25, projectileIndex: 0, count: 8, shootAngle: 45, coolDown: 1500),
                        new Shoot(25, projectileIndex: 2, count: 3, shootAngle: 10, coolDown: 1000),
                        new TimedTransition(10000, "rage"),
                        new State("Attack 4",
                            new Shoot(25, projectileIndex: 1, count: 3, shootAngle: 10, coolDown: 999999, coolDownOffset: 400),
                            new Shoot(25, projectileIndex: 3, count: 3, shootAngle: 10, coolDown: 999999, coolDownOffset: 800),
                            new Shoot(25, projectileIndex: 4, count: 3, shootAngle: 10, coolDown: 999999, coolDownOffset: 1200),
                            new Shoot(25, projectileIndex: 5, count: 3, shootAngle: 10, coolDown: 999999, coolDownOffset: 1600),
                            new Shoot(25, projectileIndex: 6, count: 3, shootAngle: 10, coolDown: 999999, coolDownOffset: 2000),
                            new TimedTransition(2000, "Attack 5")
                            ),
                        new State("Attack 5",
                            new Shoot(25, projectileIndex: 1, count: 3, shootAngle: 10, coolDown: 999999, coolDownOffset: 400),
                            new Shoot(25, projectileIndex: 3, count: 3, shootAngle: 10, coolDown: 999999, coolDownOffset: 800),
                            new Shoot(25, projectileIndex: 4, count: 3, shootAngle: 10, coolDown: 999999, coolDownOffset: 1200),
                            new Shoot(25, projectileIndex: 5, count: 3, shootAngle: 10, coolDown: 999999, coolDownOffset: 1600),
                            new Shoot(25, projectileIndex: 6, count: 3, shootAngle: 10, coolDown: 999999, coolDownOffset: 2000),
                            new TimedTransition(2500, "Attack 4")
                            )
                    ),
                    new State("rage",
                        new Follow(.1, 15, 3),
                        new Shoot(25, 30, projectileIndex: 7, coolDown: 90000001, coolDownOffset: 8000),
                        new Shoot(25, 30, projectileIndex: 8, coolDown: 90000001, coolDownOffset: 8500),
                        new Shoot(25, projectileIndex: 0, count: 8, shootAngle: 45, coolDown: 1500),
                        new Shoot(25, projectileIndex: 2, count: 3, shootAngle: 10, coolDown: 1000),
                        new TossObject("Monstrosity Scarab", 7, 0, coolDown: 5000, randomToss: true),
                        new TossObject("Monstrosity Scarab", 7, 0, coolDown: 5000, randomToss: true),
                        new TossObject("Monstrosity Scarab", 7, 0, coolDown: 5000, randomToss: true),
                        new TossObject("Monstrosity Scarab", 7, 0, coolDown: 5000, randomToss: true),
                        new Taunt(1, 6000, "Puny mortals! My {HP} HP will annihilate you!"),
                        new State("Attack 6",
                            new Shoot(25, projectileIndex: 1, count: 3, shootAngle: 10, coolDown: 999999, coolDownOffset: 400),
                            new Shoot(25, projectileIndex: 3, count: 3, shootAngle: 10, coolDown: 999999, coolDownOffset: 800),
                            new Shoot(25, projectileIndex: 4, count: 3, shootAngle: 10, coolDown: 999999, coolDownOffset: 1200),
                            new Shoot(25, projectileIndex: 5, count: 3, shootAngle: 10, coolDown: 999999, coolDownOffset: 1600),
                            new Shoot(25, projectileIndex: 6, count: 3, shootAngle: 10, coolDown: 999999, coolDownOffset: 2000),
                            new TimedTransition(2000, "Attack 7")
                            ),
                        new State("Attack 7",
                            new Shoot(25, projectileIndex: 1, count: 3, shootAngle: 10, coolDown: 999999, coolDownOffset: 400),
                            new Shoot(25, projectileIndex: 3, count: 3, shootAngle: 10, coolDown: 999999, coolDownOffset: 800),
                            new Shoot(25, projectileIndex: 4, count: 3, shootAngle: 10, coolDown: 999999, coolDownOffset: 1200),
                            new Shoot(25, projectileIndex: 5, count: 3, shootAngle: 10, coolDown: 999999, coolDownOffset: 1600),
                            new Shoot(25, projectileIndex: 6, count: 3, shootAngle: 10, coolDown: 999999, coolDownOffset: 2000),
                            new TimedTransition(2500, "Attack 6")
                            )
                    )
                ),
                new Threshold(0.01,
                    new ItemLoot("Sunshine Shiv", 0.01),
                    new ItemLoot("Spicy Wand of Spice", 0.01),
                    new ItemLoot("Doctor Swordsworth", 0.01),
                    new ItemLoot("KoalaPOW", 0.01),
                    new ItemLoot("Robobow", 0.01),
                    new ItemLoot("Arbiter's Wrath", 0.01)
                    )
              )
            .Init("Murderous Megamoth Deux",
             new State(
                 new OnDeathBehavior(new OrderOnce(999, "destnex Observer 2", "RandomBoss")),
                 new State("idle",
                     new Wander(0.2),
                     new Follow(5.0, 10, coolDown: 0),
                     new Spawn("Mini Larva Deux", maxChildren: 10, initialSpawn: 0),
                     new Reproduce("Mini Larva Deux", coolDown: 500, densityMax: 20, densityRadius: 99, spawnRadius: 0),
                     new Shoot(25, projectileIndex: 0, count: 2, shootAngle: 10, coolDown: 500, coolDownOffset: 500),
                     new Shoot(25, projectileIndex: 1, count: 1, shootAngle: 0, coolDown: 1000, coolDownOffset: 1000)
                     )
                 ),
                new Threshold(0.01,
                    new ItemLoot("KoalaPOW", 0.01)
                    )
            )
            .Init("Mini Larva Deux",
                new State(
                    new State("idle",
                        new Wander(0.1),
                        new Protect(1, "Murderous Megamoth Deux", 100, 5, 5),
                        new Shoot(10, count: 4, projectileIndex: 0, fixedAngle: fixedAngle_RingAttack2)
                        )
                    )
            )
            .Init("Lord Ruthven Deux",
                new State(
                    new OnDeathBehavior(new OrderOnce(999, "destnex Observer 2", "RandomBoss")),
                    new State("1",
                        new ConditionalEffect(ConditionEffectIndex.Invincible),
                        new PlayerWithinTransition(12, "2")
                        ),
                    new State("2",
                        new HpLessTransition(0.75, "3"),
                        new Prioritize(
                            new Wander(0.1)
                            ),
                        new Shoot(10, 3, 10, 0, coolDown: 500)
                        ),
                    new State("3",
                        new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                        new SetAltTexture(2),
                        new State("4",
                            new Shoot(99, 24, 15, 1, 0, 0, coolDown: 999999, coolDownOffset: 2000),
                            new Shoot(99, 24, 15, 1, 0, 7, coolDown: 999999, coolDownOffset: 2650),
                            new TimedTransition(3400, "5")
                            ),
                        new State("5",
                            new TossObject("Coffin Creature", 10, 0, coolDown: 999999),
                            new TossObject("Coffin Creature", 10, 90, coolDown: 999999),
                            new TossObject("Coffin Creature", 10, 180, coolDown: 999999),
                            new TossObject("Coffin Creature", 10, 270, coolDown: 999999),
                            new TimedTransition(1500, "6")
                            )
                        ),
                    new State("6",
                        new ConditionalEffect(ConditionEffectIndex.Invincible),
                        new SetAltTexture(1),
                        new Spawn("Vampire Bat Swarmer 1", 10, 0),
                        new State("9",
                            new Prioritize(
                                new Follow(1, 10, 0)
                            ),
                            new Reproduce("Vampire Bat Swarmer 1", 99, 20, 0, 100),
                            new TimedTransition(10000, "10")
                            ),
                        new State("10",
                            new ReturnToSpawn(true, 1),
                            new Reproduce("Vampire Bat Swarmer 1", 99, 20, 0, 100),
                            new TimedTransition(7000, "11")
                            ),
                        new State("11",
                            new SetAltTexture(0),
                            new Aoe(2, true, 55, 110, false, 0xFFFFFF),
                            new OrderOnce(999, "Vampire Bat Swarmer 1", "die"),
                            new TimedTransition(2000, "12")
                            )
                        ),
                    new State("12",
                        new HpLessTransition(0.5, "13"),
                        new Prioritize(
                            new Wander(0.1)
                            ),
                        new Shoot(10, 5, 10, 0, coolDown: 500)
                        ),
                    new State("13",
                        new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                        new SetAltTexture(2),
                        new State("14",
                            new Shoot(99, 24, 15, 1, 0, 0, coolDown: 999999, coolDownOffset: 2000),
                            new Shoot(99, 24, 15, 1, 0, 7, coolDown: 999999, coolDownOffset: 2650),
                            new Shoot(99, 24, 15, 1, 0, 0, coolDown: 999999, coolDownOffset: 3300),
                            new TimedTransition(4050, "15")
                            ),
                        new State("15",
                            new TossObject("Coffin Creature", 10, 0, coolDown: 999999),
                            new TossObject("Coffin Creature", 10, 90, coolDown: 999999),
                            new TossObject("Coffin Creature", 10, 180, coolDown: 999999),
                            new TossObject("Coffin Creature", 10, 270, coolDown: 999999),
                            new TimedTransition(1500, "16")
                            )
                        ),
                    new State("16",
                        new ConditionalEffect(ConditionEffectIndex.Invincible),
                        new SetAltTexture(1),
                        new Spawn("Vampire Bat Swarmer 1", 10, 0),
                        new State("17",
                            new Prioritize(
                                new Follow(1, 10, 0)
                            ),
                            new Reproduce("Vampire Bat Swarmer 1", 99, 20, 0, 100),
                            new TimedTransition(10000, "18")
                            ),
                        new State("18",
                            new ReturnToSpawn(true, 1),
                            new Reproduce("Vampire Bat Swarmer 1", 99, 20, 0, 100),
                            new TimedTransition(7000, "19")
                            ),
                        new State("19",
                            new SetAltTexture(0),
                            new Aoe(2, true, 55, 110, false, 0xFFFFFF),
                            new OrderOnce(999, "Vampire Bat Swarmer 1", "die"),
                            new TimedTransition(2000, "20")
                            )
                        ),
                    new State("20",
                        new HpLessTransition(0.25, "21"),
                        new Prioritize(
                            new Wander(0.1)
                            ),
                        new Shoot(10, 9, 10, 0, coolDown: 500)
                        ),
                    new State("21",
                        new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                        new SetAltTexture(2),
                        new State("22",
                            new Shoot(99, 24, 15, 1, 0, 0, coolDown: 999999, coolDownOffset: 2000),
                            new Shoot(99, 24, 15, 1, 0, 7, coolDown: 999999, coolDownOffset: 2650),
                            new Shoot(99, 24, 15, 1, 0, 0, coolDown: 999999, coolDownOffset: 3300),
                            new Shoot(99, 24, 15, 1, 0, 7, coolDown: 999999, coolDownOffset: 3950),
                            new TimedTransition(4700, "23")
                            ),
                        new State("23",
                            new TossObject("Coffin Creature", 10, 0, coolDown: 999999),
                            new TossObject("Coffin Creature", 10, 90, coolDown: 999999),
                            new TossObject("Coffin Creature", 10, 180, coolDown: 999999),
                            new TossObject("Coffin Creature", 10, 270, coolDown: 999999),
                            new TimedTransition(1500, "24")
                            )
                        ),
                    new State("24",
                        new ConditionalEffect(ConditionEffectIndex.Invincible),
                        new SetAltTexture(1),
                        new Spawn("Vampire Bat Swarmer 1", 10, 0),
                        new State("25",
                            new Prioritize(
                                new Follow(1, 10, 0)
                            ),
                            new Reproduce("Vampire Bat Swarmer 1", 99, 20, 0, 100),
                            new TimedTransition(10000, "26")
                            ),
                        new State("26",
                            new ReturnToSpawn(true, 1),
                            new Reproduce("Vampire Bat Swarmer 1", 99, 20, 0, 100),
                            new TimedTransition(7000, "27")
                            ),
                        new State("27",
                            new SetAltTexture(0),
                            new Aoe(2, true, 55, 110, false, 0xFFFFFF),
                            new OrderOnce(999, "Vampire Bat Swarmer 1", "die"),
                            new TimedTransition(2000, "28")
                            )
                        ),
                    new State("28",
                        new Prioritize(
                            new Wander(0.1)
                            ),
                        new Shoot(10, 18, 10, 0, coolDown: 500)
                        )
                    ),
            new Threshold(0.01,
                new ItemLoot("Sunshine Shiv", 0.01)
                )
            )
            .Init("NM Green Dragon God Deux",
                new State(
                    new OnDeathBehavior(new OrderOnce(999, "destnex Observer 4", "boss1")),
                    new SetAltTexture(1),
                    new StayCloseToSpawn(0.5, 24),
                    new State("Idle",
                        new ConditionalEffect(ConditionEffectIndex.Invincible),
                        new State("1",
                            new PlayerWithinTransition(3, "3")
                            ),
                        new State("3",
                            new SetAltTexture(0),
                            new TimedTransition(1000, "4")
                            ),
                        new State("4",
                            new TossObject("NM Green Dragon Shield", 3, 0),
                            new TossObject("NM Green Dragon Shield", 3, 45),
                            new TossObject("NM Green Dragon Shield", 3, 90),
                            new TossObject("NM Green Dragon Shield", 3, 135),
                            new TossObject("NM Green Dragon Shield", 3, 180),
                            new TossObject("NM Green Dragon Shield", 3, 225),
                            new TossObject("NM Green Dragon Shield", 3, 270),
                            new TossObject("NM Green Dragon Shield", 3, 315),
                            new TimedTransition(0, "5")
                            ),
                        new State("5",
                            new EntityExistsTransition("NM Green Dragon Shield", 999, "6")
                            ),
                        new State("6",
                            new EntitiesNotExistsTransition(999, "7", "NM Green Dragon Shield"),
                            new Shoot(99, 12, 30, 0, 0, 45, coolDown: 1500),
                            new Shoot(99, 2, 15, 6, 0, 0, coolDown: 1000),
                            new Shoot(99, 2, 15, 6, 0, 90, coolDown: 1000),
                            new Shoot(99, 2, 15, 6, 0, 180, coolDown: 1000),
                            new Shoot(99, 2, 15, 6, 0, 270, coolDown: 1000),
                            new Shoot(99, 10, 36, 5, 0, 10, coolDown: 2000),
                            new Shoot(20, 2, 15, 4, coolDown: 1000)
                            )
                        ),
                    new State("7",
                        new HpLessTransition(0.5, "8"),
                        new Follow(0.4, 20, 1),
                        new Shoot(99, 12, 30, 0, 0, 45, coolDown: 1500),
                        new Shoot(99, 2, 15, 6, 0, 0, coolDown: 1000),
                        new Shoot(99, 2, 15, 6, 0, 90, coolDown: 1000),
                        new Shoot(99, 2, 15, 6, 0, 180, coolDown: 1000),
                        new Shoot(99, 2, 15, 6, 0, 270, coolDown: 1000),
                        new Shoot(99, 10, 36, 5, 0, 10, coolDown: 2000),
                        new Shoot(20, 2, 15, 4, coolDown: 1000)
                        ),
                    new State("8",
                        new ConditionalEffect(ConditionEffectIndex.Invincible),
                        new State("9",
                            new ReturnToSpawn(true, 0.7),
                            new Flash(0xFFFFFF, 0.2, 12),
                            new TimedTransition(4000, "10")
                            ),
                        new State("10",
                            new TossObject("NM Green Dragon Shield", 3, 0),
                            new TossObject("NM Green Dragon Shield", 3, 45),
                            new TossObject("NM Green Dragon Shield", 3, 90),
                            new TossObject("NM Green Dragon Shield", 3, 135),
                            new TossObject("NM Green Dragon Shield", 3, 180),
                            new TossObject("NM Green Dragon Shield", 3, 225),
                            new TossObject("NM Green Dragon Shield", 3, 270),
                            new TossObject("NM Green Dragon Shield", 3, 315),
                            new TimedTransition(0, "11")
                            ),
                        new State("11",
                            new EntityExistsTransition("NM Green Dragon Shield", 999, "12")
                            ),
                        new State("12",
                            new EntitiesNotExistsTransition(999, "18", "NM Green Dragon Shield"),
                            new Shoot(99, 2, 15, 6, 0, 0, coolDown: 1000),
                            new Shoot(99, 2, 15, 6, 0, 90, coolDown: 1000),
                            new Shoot(99, 2, 15, 6, 0, 180, coolDown: 1000),
                            new Shoot(99, 2, 15, 6, 0, 270, coolDown: 1000),
                            new Shoot(99, 10, 36, 5, 0, 10, coolDown: 2000),
                            new Shoot(20, 2, 15, 4, coolDown: 1000),
                            new State("13",
                                new Shoot(99, 12, 30, 0, 0, 45, coolDown: 1500),
                                new TimedTransition(4500, "14")
                                ),
                            new State("14",
                                new Shoot(99, 4, 90, 0, 0, 45, coolDownOffset: 200),
                                new Shoot(99, 4, 90, 0, 0, 52, coolDownOffset: 400),
                                new Shoot(99, 4, 90, 0, 0, 59, coolDownOffset: 600),
                                new Shoot(99, 4, 90, 0, 0, 66, coolDownOffset: 800),
                                new Shoot(99, 4, 90, 0, 0, 73, coolDownOffset: 1000),
                                new Shoot(99, 4, 90, 0, 0, 80, coolDownOffset: 1200),
                                new Shoot(99, 4, 90, 0, 0, 87, coolDownOffset: 1400),
                                new Shoot(99, 4, 90, 0, 0, 90, coolDownOffset: 1600),
                                new TimedTransition(1600, "15")
                                ),
                            new State("15",
                                new Shoot(99, 4, 90, 0, 0, 90, coolDown: 200),
                                new TimedTransition(400, "16")
                                ),
                            new State("16",
                                new Shoot(99, 4, 90, 0, 0, 90, coolDownOffset: 200),
                                new Shoot(99, 4, 90, 0, 0, 87, coolDownOffset: 400),
                                new Shoot(99, 4, 90, 0, 0, 80, coolDownOffset: 600),
                                new Shoot(99, 4, 90, 0, 0, 73, coolDownOffset: 800),
                                new Shoot(99, 4, 90, 0, 0, 66, coolDownOffset: 1000),
                                new Shoot(99, 4, 90, 0, 0, 59, coolDownOffset: 1200),
                                new Shoot(99, 4, 90, 0, 0, 52, coolDownOffset: 1400),
                                new Shoot(99, 4, 90, 0, 0, 45, coolDownOffset: 1600),
                                new TimedTransition(1600, "17")
                                ),
                            new State("17",
                                new Shoot(99, 4, 90, 0, 0, 45, coolDown: 200),
                                new TimedTransition(400, "13")
                                )
                            )
                        ),
                    new State("18",
                        new Follow(0.4, 20, 1),
                        new Shoot(99, 12, 30, 0, 0, 45, coolDown: 1500),
                        new Shoot(99, 2, 15, 6, 0, 0, coolDown: 1000),
                        new Shoot(99, 2, 15, 6, 0, 90, coolDown: 1000),
                        new Shoot(99, 2, 15, 6, 0, 180, coolDown: 1000),
                        new Shoot(99, 2, 15, 6, 0, 270, coolDown: 1000),
                        new Shoot(99, 10, 36, 5, 0, 10, coolDown: 2000),
                        new Shoot(20, 2, 15, 4, coolDown: 1000)
                        )
                ),
                new Threshold(0.01,
                    new ItemLoot("Spicy Wand of Spice", 0.01)
                )
              )
               .Init("Archdemon Malphas Deux",
                new State(
                    new OnDeathBehavior(new OrderOnce(999, "destnex Observer 3", "RandomBoss")),
                    new State("default",
                        new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                        new PlayerWithinTransition(12, "basic")
                        ),
                    new State("basic",
                        new Prioritize(
                            new Follow(0.3),
                            new Wander(0.2)
                            ),
                        new Reproduce("Malphas Missile", densityMax: 1, spawnRadius: 1, coolDown: 1000),
                        new Spawn(children: "Malphas Protector Deux", maxChildren: 3),
                        new Shoot(10, predictive: 1, coolDown: 900),
                        new TimedTransition(11500, "shrink"),
                        new State("1",
                            new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                            new TimedTransition(2500, "2")
                            ),
                        new State("2")
                        ),
                    new State("shrink",
                        new Wander(0.4),
                        new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                        new ChangeSize(-15, 25),
                        new TimedTransition(1000, "smallAttack")
                        ),
                    new State("smallAttack",
                        new Prioritize(
                            new Follow(1, acquireRange: 15, range: 8),
                            new Wander(1)
                            ),
                        new Shoot(10, predictive: 1, coolDown: 900),
                        new Shoot(10, 6, projectileIndex: 1, predictive: 1, coolDown: 1200),
                        new TimedTransition(11000, "grow")
                        ),
                    new State("grow",
                        new Wander(0.1),
                        new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                        new ChangeSize(35, 200),
                        new TimedTransition(1050, "bigAttack")
                        ),
                    new State("bigAttack",
                        new Prioritize(
                            new Follow(0.2),
                            new Wander(0.1)
                            ),
                        new Shoot(10, projectileIndex: 2, predictive: 1, coolDown: 700),
                        new Shoot(10, 3, projectileIndex: 3, predictive: 1, coolDown: 900),
                        new TimedTransition(11600, "normalize"),
                        new State("WaitToSetShield1",
                            new TimedTransition(1400, "SetShield1")
                            ),
                        new State("SetShield1",
                            new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                            new TimedTransition(1400, "WaitToSetShield2")
                            ),
                        new State("WaitToSetShield2",
                            new TimedTransition(1400, "SetShield2")
                            ),
                        new State("SetShield2",
                            new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                            new TimedTransition(1400, "WaitToSetShield3")
                            ),
                        new State("WaitToSetShield3",
                            new TimedTransition(1400, "SetShield3")
                            ),
                        new State("SetShield3",
                            new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                            new TimedTransition(1400, "WaitToSetShield4")
                            ),
                        new State("WaitToSetShield4",
                            new TimedTransition(1400, "SetShield4")
                            ),
                        new State("SetShield4",
                            new ConditionalEffect(ConditionEffectIndex.Invulnerable)
                            )
                        ),
                    new State("normalize",
                        new Wander(0.3),
                        new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                        new ChangeSize(-20, 100),
                        new TimedTransition(1000, "spawnMalphasFlamer")
                        ),
                    new State("spawnMalphasFlamer",
                        new Prioritize(
                            new Follow(0.3),
                            new Wander(0.2)
                            ),
                        new Spawn(children: "Malphas Protector Deux", maxChildren: 4),
                        new Spawn(children: "Malphas Flamer Deux", maxChildren: 5),
                        new Shoot(12, predictive: 1, coolDown: 3200),
                        new TimedTransition(8000, "basic")
                        )
                    ),
                 new Threshold(0.01,
                    new ItemLoot("Arbiter's Wrath", 0.01)
                    )
            )
            .Init("Malphas Protector Deux",
                new State(
                    new Orbit(speed: 1.5, radius: 7, acquireRange: 99, target: "Archdemon Malphas Deux"),
                    new Shoot(radius: 5, count: 3, shootAngle: 5)
                    )
            )
            .Init("Malphas Flamer Deux",
                new State(
                    new State("Follow",
                        new ChangeSize(-25, 100),
                        new Follow(0.3, 8, 0),
                        new TimedTransition(3000, "Fire!!!")
                        ),
                    new State("Fire!!!",
                        new ChangeSize(25, 200),
                        new Shoot(8, 1, coolDown: 200),
                        new TimedTransition(2000, "Follow")
                        )
                    )
            )
            .Init("Stheno the Snake Queen Deux",
                new State(
                    new OnDeathBehavior(new OrderOnce(999, "destnex Observer 3", "RandomBoss")),
                    new State("Idle",
                        new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                        new PlayerWithinTransition(20, "Silver Blasts")
                    ),
                    new State("Silver Blasts",
                        new State("Silver Blasts 1",
                            new ConditionalEffect(ConditionEffectIndex.Invulnerable, true),
                            new Shoot(10, count: 2, shootAngle: 10, angleOffset: 45, projectileIndex: 0),
                            new Shoot(10, count: 1, angleOffset: 135, projectileIndex: 0),
                            new Shoot(10, count: 1, angleOffset: 225, projectileIndex: 0),
                            new Shoot(10, count: 2, shootAngle: 10, angleOffset: 315, projectileIndex: 0),
                            new TimedTransition(1000, "Silver Blasts 2")
                        ),
                        new State("Silver Blasts 2",
                            new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                            new Shoot(10, count: 2, shootAngle: 10, angleOffset: 45, projectileIndex: 0),
                            new Shoot(10, count: 1, angleOffset: 135, projectileIndex: 0),
                            new Shoot(10, count: 1, angleOffset: 225, projectileIndex: 0),
                            new Shoot(10, count: 2, shootAngle: 10, angleOffset: 315, projectileIndex: 0),
                            new TimedTransition(1000, "Silver Blasts 3")
                        ),
                        new State("Silver Blasts 3",
                            new Shoot(10, count: 2, shootAngle: 10, angleOffset: 45, projectileIndex: 0),
                            new Shoot(10, count: 1, angleOffset: 135, projectileIndex: 0),
                            new Shoot(10, count: 1, angleOffset: 225, projectileIndex: 0),
                            new Shoot(10, count: 2, shootAngle: 10, angleOffset: 315, projectileIndex: 0),
                            new TimedTransition(1000, "Silver Blasts 4")
                        ),
                        new State("Silver Blasts 4",
                            new ConditionalEffect(ConditionEffectIndex.Invulnerable, true),
                            new Shoot(10, count: 2, shootAngle: 10, angleOffset: 45, projectileIndex: 0),
                            new Shoot(10, count: 1, angleOffset: 135, projectileIndex: 0),
                            new Shoot(10, count: 1, angleOffset: 225, projectileIndex: 0),
                            new Shoot(10, count: 2, shootAngle: 10, angleOffset: 315, projectileIndex: 0),
                            new TimedTransition(1000, "Silver Blasts 5")
                        ),
                        new State("Silver Blasts 5",
                            new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                            new Shoot(10, count: 2, shootAngle: 10, angleOffset: 45, projectileIndex: 0),
                            new Shoot(10, count: 1, angleOffset: 135, projectileIndex: 0),
                            new Shoot(10, count: 1, angleOffset: 225, projectileIndex: 0),
                            new Shoot(10, count: 2, shootAngle: 10, angleOffset: 315, projectileIndex: 0),
                            new TimedTransition(1000, "Silver Blasts 6")
                        ),
                        new State("Silver Blasts 6",
                            new Shoot(10, count: 2, shootAngle: 10, angleOffset: 45, projectileIndex: 0),
                            new Shoot(10, count: 1, angleOffset: 135, projectileIndex: 0),
                            new Shoot(10, count: 1, angleOffset: 225, projectileIndex: 0),
                            new Shoot(10, count: 2, shootAngle: 10, angleOffset: 315, projectileIndex: 0),
                            new TimedTransition(1000, "Silver Blasts 7")
                        ),
                        new State("Silver Blasts 7",
                            new ConditionalEffect(ConditionEffectIndex.Invulnerable, true),
                            new Shoot(10, count: 2, shootAngle: 10, angleOffset: 45, projectileIndex: 0),
                            new Shoot(10, count: 1, angleOffset: 135, projectileIndex: 0),
                            new Shoot(10, count: 1, angleOffset: 225, projectileIndex: 0),
                            new Shoot(10, count: 2, shootAngle: 10, angleOffset: 315, projectileIndex: 0),
                            new TimedTransition(1000, "Silver Blasts 8")
                        ),
                        new State("Silver Blasts 8",
                            new ConditionalEffect(ConditionEffectIndex.Invulnerable, true),
                            new Shoot(10, count: 2, shootAngle: 10, angleOffset: 45, projectileIndex: 0),
                            new Shoot(10, count: 1, angleOffset: 135, projectileIndex: 0),
                            new Shoot(10, count: 1, angleOffset: 225, projectileIndex: 0),
                            new Shoot(10, count: 2, shootAngle: 10, angleOffset: 315, projectileIndex: 0),
                            new TimedTransition(1000, "Spawn Stheno Swarm")
                        )
                    ),
                    new State("Spawn Stheno Swarm",
                        new Prioritize(
                            new StayCloseToSpawn(0.4, 2),
                            new Wander(0.4)
                        ),
                        new Reproduce("Stheno Swarm Deux", 2.5, 8, coolDown: 750),
                        new State("Silver Blast 1",
                            new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                            new Shoot(10, count: 1, projectileIndex: 0),
                            new Shoot(10, count: 1, angleOffset: 270, projectileIndex: 0),
                            new Shoot(10, count: 1, angleOffset: 90, projectileIndex: 0),
                            new TimedTransition(1000, "Silver Blast 2")
                        ),
                        new State("Silver Blast 2",
                            new Shoot(10, count: 1, projectileIndex: 0),
                            new Shoot(10, count: 1, angleOffset: 270, projectileIndex: 0),
                            new Shoot(10, count: 1, angleOffset: 90, projectileIndex: 0),
                            new TimedTransition(1000, "Silver Blast 3")
                        ),
                        new State("Silver Blast 3",
                            new ConditionalEffect(ConditionEffectIndex.Invulnerable, true),
                            new Shoot(10, count: 1, projectileIndex: 0),
                            new Shoot(10, count: 1, angleOffset: 270, projectileIndex: 0),
                            new Shoot(10, count: 1, angleOffset: 90, projectileIndex: 0),
                            new TimedTransition(1000, "Silver Blast 4")
                        ),
                        new State("Silver Blast 4",
                            new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                            new Shoot(10, count: 1, projectileIndex: 0),
                            new Shoot(10, count: 1, angleOffset: 270, projectileIndex: 0),
                            new Shoot(10, count: 1, angleOffset: 90, projectileIndex: 0),
                            new TimedTransition(1000, "Silver Blast 5")
                        ),
                        new State("Silver Blast 5",
                            new Shoot(10, count: 1, projectileIndex: 0),
                            new Shoot(10, count: 1, angleOffset: 270, projectileIndex: 0),
                            new Shoot(10, count: 1, angleOffset: 90, projectileIndex: 0),
                            new TimedTransition(1000, "Silver Blast 6")
                        ),
                        new State("Silver Blast 6",
                            new ConditionalEffect(ConditionEffectIndex.Invulnerable, true),
                            new Shoot(10, count: 1, projectileIndex: 0),
                            new Shoot(10, count: 1, angleOffset: 270, projectileIndex: 0),
                            new Shoot(10, count: 1, angleOffset: 90, projectileIndex: 0),
                            new TimedTransition(1000, "Silver Blast 7")
                        ),
                        new State("Silver Blast 7",
                            new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                            new Shoot(10, count: 1, projectileIndex: 0),
                            new Shoot(10, count: 1, angleOffset: 270, projectileIndex: 0),
                            new Shoot(10, count: 1, angleOffset: 90, projectileIndex: 0),
                            new TimedTransition(1000, "Silver Blast 8")
                        ),
                        new State("Silver Blast 8",
                            new Shoot(10, count: 1, projectileIndex: 0),
                            new Shoot(10, count: 1, angleOffset: 270, projectileIndex: 0),
                            new Shoot(10, count: 1, angleOffset: 90, projectileIndex: 0),
                            new TimedTransition(1000, "Silver Blast 9")
                        ),
                        new State("Silver Blast 9",
                            new ConditionalEffect(ConditionEffectIndex.Invulnerable, true),
                            new Shoot(10, count: 1, projectileIndex: 0),
                            new Shoot(10, count: 1, angleOffset: 270, projectileIndex: 0),
                            new Shoot(10, count: 1, angleOffset: 90, projectileIndex: 0),
                            new TimedTransition(1000, "Silver Blast 10")
                        ),
                        new State("Silver Blast 10",
                            new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                            new Shoot(10, count: 1, projectileIndex: 0),
                            new Shoot(10, count: 1, angleOffset: 270, projectileIndex: 0),
                            new Shoot(10, count: 1, angleOffset: 90, projectileIndex: 0),
                            new TimedTransition(1000, "Silver Blast 11")
                        ),
                        new State("Silver Blast 11",
                            new Shoot(10, count: 1, projectileIndex: 0),
                            new Shoot(10, count: 1, angleOffset: 270, projectileIndex: 0),
                            new Shoot(10, count: 1, angleOffset: 90, projectileIndex: 0),
                            new TimedTransition(1000, "Silver Blast 12")
                        ),
                        new State("Silver Blast 12",
                            new ConditionalEffect(ConditionEffectIndex.Invulnerable, true),
                            new Shoot(10, count: 1, projectileIndex: 0),
                            new Shoot(10, count: 1, angleOffset: 270, projectileIndex: 0),
                            new Shoot(10, count: 1, angleOffset: 90, projectileIndex: 0),
                            new TimedTransition(1000, "Silver Blast 13")
                        ),
                        new State("Silver Blast 13",
                            new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                            new Shoot(10, count: 1, projectileIndex: 0),
                            new Shoot(10, count: 1, angleOffset: 270, projectileIndex: 0),
                            new Shoot(10, count: 1, angleOffset: 90, projectileIndex: 0),
                            new TimedTransition(1000, "Silver Blast 14")
                        ),
                        new State("Silver Blast 14",
                            new Shoot(10, count: 1, projectileIndex: 0),
                            new Shoot(10, count: 1, angleOffset: 270, projectileIndex: 0),
                            new Shoot(10, count: 1, angleOffset: 90, projectileIndex: 0),
                            new TimedTransition(1000, "Silver Blast 15")
                        ),
                        new State("Silver Blast 15",
                            new ConditionalEffect(ConditionEffectIndex.Invulnerable, true),
                            new Shoot(10, count: 1, projectileIndex: 0),
                            new Shoot(10, count: 1, angleOffset: 270, projectileIndex: 0),
                            new Shoot(10, count: 1, angleOffset: 90, projectileIndex: 0),
                            new TimedTransition(1000, "Silver Blast 16")
                        ),
                        new State("Silver Blast 16",
                            new Shoot(10, count: 1, projectileIndex: 0),
                            new Shoot(10, count: 1, angleOffset: 270, projectileIndex: 0),
                            new Shoot(10, count: 1, angleOffset: 90, projectileIndex: 0),
                            new TimedTransition(1000, "Leave me")
                        ),
                        new State("Leave me",
                            new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                            new Order(100, "Stheno Swarm Deux", "Despawn"),
                            new TimedTransition(1000, "Blind Ring Attack + ThrowAttack")
                        )
                    ),
                    new State("Blind Ring Attack + ThrowAttack",
                        new ReturnToSpawn(speed: 0.3),
                        new State("Blind Ring Attack + ThrowAttack 1",
                            new Shoot(10, count: 6, projectileIndex: 1),
                            new Grenade(2.5, 100, 10),
                            new TimedTransition(500, "Blind Ring Attack + ThrowAttack 2")
                        ),
                        new State("Blind Ring Attack + ThrowAttack 2",
                            new Shoot(10, count: 6, projectileIndex: 1),
                            new Grenade(2.5, 100, 10),
                            new TimedTransition(500, "Blind Ring Attack + ThrowAttack 3")
                        ),
                        new State("Blind Ring Attack + ThrowAttack 3",
                            new Shoot(10, count: 6, projectileIndex: 1),
                            new Grenade(2.5, 100, 10),
                            new TimedTransition(500, "Blind Ring Attack + ThrowAttack 4")
                        ),
                        new State("Blind Ring Attack + ThrowAttack 4",
                            new ConditionalEffect(ConditionEffectIndex.Invulnerable, true),
                            new Shoot(10, count: 6, projectileIndex: 1),
                            new Grenade(2.5, 100, 10),
                            new TimedTransition(500, "Blind Ring Attack + ThrowAttack 5")
                        ),
                        new State("Blind Ring Attack + ThrowAttack 5",
                            new Shoot(10, count: 6, projectileIndex: 1),
                            new Grenade(2.5, 100, 10),
                            new TimedTransition(500, "Blind Ring Attack + ThrowAttack 6")
                        ),
                        new State("Blind Ring Attack + ThrowAttack 6",
                            new Shoot(10, count: 6, projectileIndex: 1),
                            new Grenade(2.5, 100, 10),
                            new TimedTransition(500, "Blind Ring Attack + ThrowAttack 7")
                        ),
                        new State("Blind Ring Attack + ThrowAttack 7",
                            new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                            new Shoot(10, count: 6, projectileIndex: 1),
                            new Grenade(2.5, 100, 10),
                            new TimedTransition(500, "Blind Ring Attack + ThrowAttack 8")
                        ),
                        new State("Blind Ring Attack + ThrowAttack 8",
                            new Shoot(10, count: 6, projectileIndex: 1),
                            new Grenade(2.5, 100, 10),
                            new TimedTransition(500, "Blind Ring Attack + ThrowAttack 9")
                        ),
                        new State("Blind Ring Attack + ThrowAttack 9",
                            new Shoot(10, count: 6, projectileIndex: 1),
                            new Grenade(2.5, 100, 10),
                            new TimedTransition(500, "Blind Ring Attack + ThrowAttack 10")
                        ),
                        new State("Blind Ring Attack + ThrowAttack 10",
                            new Shoot(10, count: 6, projectileIndex: 1),
                            new Grenade(2.5, 100, 10),
                            new TimedTransition(500, "Blind Ring Attack + ThrowAttack 11")
                        ),
                        new State("Blind Ring Attack + ThrowAttack 11",
                            new ConditionalEffect(ConditionEffectIndex.Invulnerable, true),
                            new Shoot(10, count: 6, projectileIndex: 1),
                            new Grenade(2.5, 100, 10),
                            new TimedTransition(500, "Blind Ring Attack + ThrowAttack 12")
                        ),
                        new State("Blind Ring Attack + ThrowAttack 12",
                            new Shoot(10, count: 6, projectileIndex: 1),
                            new Grenade(2.5, 100, 10),
                            new TimedTransition(500, "Silver Blasts")
                        )
                    )
                ),
                new Threshold(0.01,
                    new ItemLoot("Doctor Swordsworth", 0.01)
                )
            )
            .Init("Stheno Swarm Deux",
                new State(
                    new State("Protect",
                        new Prioritize(
                            new Protect(0.3, "Stheno the Snake Queen Deux"),
                            new Wander(0.3)
                        ),
                        new Shoot(10, coolDown: new Cooldown(750, 250))
                    ),
                    new State("Despawn",
                        new Suicide()
                    )
                )
            )
            .Init("Golden Oryx Effigy Deux",
                new State(
                    new OnDeathBehavior(new OrderOnce(999, "destnex Observer 4", "boss1")),
                    new State("1",
                        new ConditionalEffect(ConditionEffectIndex.Invincible),
                        new PlayerWithinTransition(3, "2")
                        ),
                    new State("2",
                        new ConditionalEffect(ConditionEffectIndex.Invulnerable, true),
                        new ChangeSize(25, 200),
                        new TimedTransition(0, "Toss Objects")
                        ),
                    new State("Toss Objects",
                        new TossObject("Treasure Oryx Defender Deux", 4, 0, coolDown: 99999),
                        new TossObject("Treasure Oryx Defender Deux", 4, 90, coolDown: 99999),
                        new TossObject("Treasure Oryx Defender Deux", 4, 180, coolDown: 99999),
                        new TossObject("Treasure Oryx Defender Deux", 4, 270, coolDown: 99999),
                        new TossObject("Gold Planet Deux", 9, 0, coolDown: 99999),
                        new TossObject("Gold Planet Deux", 9, 45, coolDown: 99999),
                        new TossObject("Gold Planet Deux", 9, 90, coolDown: 99999),
                        new TossObject("Gold Planet Deux", 9, 135, coolDown: 99999),
                        new TossObject("Gold Planet Deux", 9, 180, coolDown: 99999),
                        new TossObject("Gold Planet Deux", 9, 225, coolDown: 99999),
                        new TossObject("Gold Planet Deux", 9, 270, coolDown: 99999),
                        new TimedTransition(7000, "Check 1")
                        ),
                    new State("Check 1",
                        new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                        new EntitiesNotExistsTransition(20, "3", "Treasure Oryx Defender Deux")
                        ),
                    new State("3",
                        new Taunt("My guardians are gone!"),
                        new SetAltTexture(2),
                        new TimedTransition(500, "4")
                        ),
                    new State("4",
                        new SetAltTexture(1),
                        new TimedTransition(500, "5")
                        ),
                    new State("5",
                        new SetAltTexture(0),
                        new TimedTransition(500, "6")
                        ),
                    new State("6",
                        new SetAltTexture(1),
                        new TimedTransition(500, "7")
                        ),
                    new State("7",
                        new SetAltTexture(0),
                        new TimedTransition(500, "8")
                        ),
                    new State("8",
                        new SetAltTexture(1),
                        new TimedTransition(500, "9")
                        ),
                    new State("9",
                        new SetAltTexture(0),
                        new TimedTransition(500, "10")
                        ),
                    new State("10",
                        new SetAltTexture(1),
                        new TimedTransition(500, "11")
                        ),
                    new State("11",
                        new SetAltTexture(0),
                        new TimedTransition(500, "12")
                        ),
                    new State("12",
                        new SetAltTexture(1),
                        new TimedTransition(500, "13")
                        ),
                    new State("13",
                        new SetAltTexture(0),
                        new TimedTransition(500, "14")
                        ),
                    new State("14",
                        new ConditionalEffect(ConditionEffectIndex.Invulnerable, true),
                        new SetAltTexture(0),
                        new ChangeSize(25, 175),
                        new TossObject("Treasure Oryx Defender Deux", 4, 0, coolDown: 99999),
                        new TossObject("Treasure Oryx Defender Deux", 4, 90, coolDown: 99999),
                        new TossObject("Treasure Oryx Defender Deux", 4, 180, coolDown: 99999),
                        new TossObject("Treasure Oryx Defender Deux", 4, 270, coolDown: 99999),
                        new TimedTransition(5000, "Check 2")
                        ),
                    new State("Check 2",
                        new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                        new EntitiesNotExistsTransition(20, "15", "Treasure Oryx Defender Deux")
                        ),
                    new State("15",
                        new Taunt("My Protectors!"),
                        new SetAltTexture(2),
                        new TimedTransition(500, "16")
                        ),
                    new State("16",
                        new SetAltTexture(1),
                        new TimedTransition(500, "17")
                        ),
                    new State("17",
                        new SetAltTexture(0),
                        new TimedTransition(500, "18")
                        ),
                    new State("18",
                        new SetAltTexture(1),
                        new TimedTransition(500, "19")
                        ),
                    new State("19",
                        new Taunt("I'm weakened"),
                        new Flash(0x2216FF, .1, 15),
                        new Grenade(4, 70, 10, coolDown: 750),
                        new TimedTransition(1500, "20")
                        ),
                    new State("20",
                        new Shoot(50, 4, shootAngle: 90, projectileIndex: 1, fixedAngle: 0, angleOffset: 45),
                        new TimedTransition(200, "21")
                        ),
                    new State("21",
                        new Shoot(50, 4, shootAngle: 90, projectileIndex: 1, fixedAngle: 0, angleOffset: 55),
                        new TimedTransition(200, "22")
                        ),
                    new State("22",
                        new Shoot(50, 4, shootAngle: 90, projectileIndex: 1, fixedAngle: 0, angleOffset: 65),
                        new TimedTransition(200, "23")
                        ),
                    new State("23",
                        new Shoot(50, 4, shootAngle: 90, projectileIndex: 1, fixedAngle: 0, angleOffset: 75),
                        new TimedTransition(200, "24")
                        ),
                    new State("24",
                        new Shoot(50, 4, shootAngle: 90, projectileIndex: 1, fixedAngle: 0, angleOffset: 85),
                        new TimedTransition(200, "25")
                        ),
                    new State("25",
                        new Shoot(50, 4, shootAngle: 90, projectileIndex: 1, fixedAngle: 0, angleOffset: 95),
                        new TimedTransition(200, "26")
                        ),
                    new State("26",
                        new Shoot(50, 4, shootAngle: 90, projectileIndex: 1, fixedAngle: 0, angleOffset: 105),
                        new TimedTransition(200, "27")
                        ),
                    new State("27",
                        new Shoot(50, 4, shootAngle: 90, projectileIndex: 1, fixedAngle: 0, angleOffset: 115),
                        new TimedTransition(200, "28")
                        ),
                    new State("28",
                        new Shoot(50, 4, shootAngle: 90, projectileIndex: 1, fixedAngle: 0, angleOffset: 105),
                        new TimedTransition(200, "29")
                        ),
                    new State("29",
                        new Shoot(50, 4, shootAngle: 90, projectileIndex: 1, fixedAngle: 0, angleOffset: 95),
                        new TimedTransition(200, "30")
                        ),
                    new State("30",
                        new Shoot(50, 4, shootAngle: 90, projectileIndex: 1, fixedAngle: 0, angleOffset: 85),
                        new TimedTransition(200, "31")
                        ),
                    new State("31",
                        new Shoot(50, 4, shootAngle: 90, projectileIndex: 1, fixedAngle: 0, angleOffset: 75),
                        new TimedTransition(200, "32")
                        ),
                    new State("32",
                        new Shoot(50, 4, shootAngle: 90, projectileIndex: 1, fixedAngle: 0, angleOffset: 65),
                        new TimedTransition(200, "33")
                        ),
                    new State("33",
                        new Shoot(50, 4, shootAngle: 90, projectileIndex: 1, fixedAngle: 0, angleOffset: 55),
                        new TimedTransition(200, "34")
                        ),
                    new State("34",
                        new Shoot(50, 4, shootAngle: 90, projectileIndex: 1, fixedAngle: 0, angleOffset: 45),
                        new TimedTransition(200, "35")
                        ),
                    new State("35",
                        new Shoot(50, 4, shootAngle: 90, projectileIndex: 1, fixedAngle: 0, angleOffset: 35),
                        new TimedTransition(200, "36")
                        ),
                    new State("36",
                        new Shoot(50, 8, shootAngle: 45, projectileIndex: 0, fixedAngle: 0),
                        new TimedTransition(200, "14")
                        )
                    ),
            new Threshold(0.01,
                new ItemLoot("Robobow", 0.01)
                )
            )
        .Init("Treasure Oryx Defender Deux",
            new State(
                new Orbit(0.2, radius: 4, target: "Golden Oryx Effigy Deux"),
                new State("1",
                    new Shoot(20, 8, shootAngle: 45, projectileIndex: 0, fixedAngle: 0, coolDown: 1000)
                    )
                )
            )
        .Init("Gold Planet Deux",
            new State(
                new Orbit(0.2, radius: 9, target: "Golden Oryx Effigy Deux"),
                new ConditionalEffect(ConditionEffectIndex.Invincible),
                new State("1",
                    new Shoot(20, 1, projectileIndex: 0, fixedAngle: 0, angleOffset: 0, coolDown: 1000),
                    new Shoot(20, 1, projectileIndex: 0, fixedAngle: 0, angleOffset: 180, coolDown: 1000),
                    new Shoot(20, 1, projectileIndex: 1, fixedAngle: 0, angleOffset: 0, coolDown: 5000),
                    new Shoot(20, 1, projectileIndex: 1, fixedAngle: 0, angleOffset: 180, coolDown: 5000),
                    new EntitiesNotExistsTransition(99, "2", "Golden Oryx Effigy Deux")
                    ),
                new State("2",
                    new Suicide()
                    )
                )
            );
    }
}