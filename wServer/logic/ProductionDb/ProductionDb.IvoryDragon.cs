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

        private _ lodw = () => Behav()
            .Init("lod Ivory Wyvern",
                   new State(
                       new OnDeathBehavior(new RealmPortalDrop()),
                       new TransformOnDeath("lod Ivory Loot", 1, 1, 1),
                    new State("idle",
                        new PlayerWithinTransition(15, "start")
                    ),
                new State("start",
                    new ConditionalEffect(ConditionEffectIndex.Invulnerable, false),
                    new Taunt("Thank you adventurer, you have freed the souls of the four dragons so that i may consume their powers"),
                    new TimedTransition(3000, "start2")
                     ),
                new State("start2",
                    new ConditionalEffect(ConditionEffectIndex.Invulnerable, false),
                    new Taunt("I owe you much, but i cannot let you leave. These walls will make a fine graveyard for your bones"),
                    new TossObject("lod Mirror Wyvern1", 8, 180, coolDown: 50000),
                    new TossObject("lod Mirror Wyvern2", 4, 180, coolDown: 50000),
                    new TossObject("lod Mirror Wyvern3", 4, 0, coolDown: 50000),
                    new TossObject("lod Mirror Wyvern4", 8, 0, coolDown: 50000),
                    new TimedTransition(1000, "start3")
                    ),
                new State("start3",
                    new Taunt("Behold the glory of my true powers"),
                    new MoveTo(0, 1, 0.5),
                    new Shoot(20, 9, 20, 0, 90, coolDown: 5000),
                    new TimedTransition(1500, "start4")
                    ),
                new State("start4",
                    new Taunt("Run little hero, as fast as you can"),
                    new MoveTo(6, 0, 0.5),
                    new Shoot(20, 1, 1, 0, coolDown: 2500, coolDownOffset: 0),
                    new Shoot(20, 1, 1, 0, coolDown: 2500, coolDownOffset: 250),
                    new Shoot(20, 1, 1, 0, coolDown: 2500, coolDownOffset: 500),
                    new Shoot(20, 1, 1, 0, coolDown: 2500, coolDownOffset: 750),
                    new HpLessOrder(50, 0.7, "lod Mirror Wyvern1", "suicide"),
                    new HpLessOrder(50, 0.7, "lod Mirror Wyvern2", "suicide"),
                    new HpLessOrder(50, 0.7, "lod Mirror Wyvern3", "suicide"),
                    new HpLessOrder(50, 0.7, "lod Mirror Wyvern4", "suicide"),
                    new HpLessTransition(0.7, "wat")
                    ),
                new State("wat",
                    new Taunt("My magic can no longer sustain my Mirrors, what have you done?"),
                    new MoveTo(-12, 0, 0.7),
                    new Shoot(20, 9, 20, 0, 90, coolDown: 1000),
                    new HpLessTransition(0.5, "throwS"),
                    new TimedTransition(5000, "wat2")
                      ),
                new State("wat2",
                    new MoveTo(12, 0, 0.7),
                    new Shoot(20, 9, 20, 0, 90, coolDown: 1000),
                    new HpLessTransition(0.5, "throwS"),
                    new TimedTransition(5000, "wat")
                     ),
                new State("throwS",
                    new ConditionalEffect(ConditionEffectIndex.Invulnerable, false),
                    new ReturnToSpawn(speed: 0.5),
                    new TimedTransition(5000, "throwSouls")
                     ),
                new State("throwSouls",
                    new ConditionalEffect(ConditionEffectIndex.Invulnerable, false),
                    new TossObject("lod Blue Soul Flame", 8, 180, coolDown: 50000),
                    new TossObject("lod Green Soul Flame", 4, 180, coolDown: 50000),
                    new TossObject("lod Red Soul Flame", 4, 0, coolDown: 50000),
                    new TossObject("lod Black Soul Flame", 8, 0, coolDown: 50000),
                    new TimedTransition(3000, "checkSouls")
                    ),
                new State("checkSouls",
                    new ConditionalEffect(ConditionEffectIndex.Invulnerable, false),
                    new EntitiesNotExistsTransition(50, "rampage", "lod Blue Soul Flame", "lod Green Soul Flame", "lod Red Soul Flame", "lod Black Soul Flame")
                     ),
                new State("rampage",
                     new ConditionalEffect(ConditionEffectIndex.Invulnerable, false),
                     new MoveTo(0, 12, 0.5),
                     new TimedTransition(5000, "startrainbow")
                     ),
                new State("startrainbow",
                     new Shoot(50, 5, 20, 1, 90, coolDown: 1000),
                     new Shoot(50, 5, 20, 2, 0, coolDown: 1000),
                     new Shoot(50, 5, 20, 3, 270, coolDown: 1000),
                     new Shoot(50, 5, 20, 4, 180, coolDown: 1000),
                     new TimedTransition(900, "startrainbow2")
                     ),
                new State("startrainbow2",
                     new Shoot(50, 5, 20, 4, 90, coolDown: 1000),
                     new Shoot(50, 5, 20, 1, 0, coolDown: 1000),
                     new Shoot(50, 5, 20, 2, 270, coolDown: 1000),
                     new Shoot(50, 5, 20, 3, 180, coolDown: 1000),
                     new TimedTransition(900, "startrainbow3")
                     ),
                new State("startrainbow3",
                     new Shoot(50, 5, 20, 3, 90, coolDown: 1000),
                     new Shoot(50, 5, 20, 4, 0, coolDown: 1000),
                     new Shoot(50, 5, 20, 1, 270, coolDown: 1000),
                     new Shoot(50, 5, 20, 2, 180, coolDown: 1000),
                     new TimedTransition(900, "startrainbow4")
                     ),
                new State("startrainbow4",
                     new Shoot(50, 5, 20, 2, 90, coolDown: 1000),
                     new Shoot(50, 5, 20, 3, 0, coolDown: 1000),
                     new Shoot(50, 5, 20, 4, 270, coolDown: 1000),
                     new Shoot(50, 5, 20, 1, 180, coolDown: 1000),
                     new TimedTransition(2000, "startspawnshootin")
                    ),
                new State("startspawnshootin",
                     new Shoot(50, 1, 1, 0, coolDown: 1000),
                     new TossObject("lod White Dragon Orb", 11, 315, coolDown: 50000),
                     new TossObject("lod White Dragon Orb", 11, 45, coolDown: 50000),
                     new TossObject("lod White Dragon Orb", 11, 135, coolDown: 50000),
                     new TossObject("lod White Dragon Orb", 11, 225, coolDown: 50000),
                     new TimedTransition(1000, "fixbug")
                     ),
                new State("fixbug",
                     new Shoot(50, 1, 1, 0, coolDown: 1000),
                     new HpLessTransition(0.25, "rage")
                    ),
                new State("rage",
                    new Follow(0.6, 8, 1),
                     new Shoot(20, 9, 20, 0, coolDown: 1000),
                     new HpLessTransition(0.05, "ded")
                      ),
                new State("ded",
                    new ConditionalEffect(ConditionEffectIndex.Invulnerable, false),
                    new Order(50, "lod White Dragon Orb", "suicide"),
                    new Taunt("You may have beaten my this time, but i will find a way to leave this place! And on that day you will suffer greatly..."),
                     new TimedTransition(5000, "chest")
                    ),
                new State("chest",
                    new Suicide()
                    )))
        .Init("lod Mirror Wyvern1",
                   new State(
                    new State("idle",
                        new PlayerWithinTransition(15, "start")
                        ),
                    new State("start",
                        new ConditionalEffect(ConditionEffectIndex.Invulnerable, false),
                       new Shoot(20, 1, 1, 0, coolDown: 2500, coolDownOffset: 0),
                    new Shoot(20, 1, 1, 0, coolDown: 2500, coolDownOffset: 250),
                    new Shoot(20, 1, 1, 0, coolDown: 2500, coolDownOffset: 500),
                    new Shoot(20, 1, 1, 0, coolDown: 2500, coolDownOffset: 750)
                            ),
                    new State("suicide",
                     new Suicide()
                         )))
        .Init("lod Mirror Wyvern2",
                   new State(
                    new State("idle",
                        new PlayerWithinTransition(15, "start")
                        ),
                    new State("start",
                        new ConditionalEffect(ConditionEffectIndex.Invulnerable, false),
                       new Shoot(20, 1, 1, 0, coolDown: 2500, coolDownOffset: 0),
                    new Shoot(20, 1, 1, 0, coolDown: 2500, coolDownOffset: 250),
                    new Shoot(20, 1, 1, 0, coolDown: 2500, coolDownOffset: 500),
                    new Shoot(20, 1, 1, 0, coolDown: 2500, coolDownOffset: 750)
                            ),
                    new State("suicide",
                     new Suicide()
                         )))
        .Init("lod Mirror Wyvern3",
                   new State(
                    new State("idle",
                        new PlayerWithinTransition(15, "start")
                        ),
                    new State("start",
                        new ConditionalEffect(ConditionEffectIndex.Invulnerable, false),
                       new Shoot(20, 1, 1, 0, coolDown: 2500, coolDownOffset: 0),
                    new Shoot(20, 1, 1, 0, coolDown: 2500, coolDownOffset: 250),
                    new Shoot(20, 1, 1, 0, coolDown: 2500, coolDownOffset: 500),
                    new Shoot(20, 1, 1, 0, coolDown: 2500, coolDownOffset: 750)
                            ),
                    new State("suicide",
                     new Suicide()
                         )))
        .Init("lod Mirror Wyvern4",
                   new State(
                    new State("idle",
                        new PlayerWithinTransition(15, "start")
                        ),
                    new State("start",
                        new ConditionalEffect(ConditionEffectIndex.Invulnerable, false),
                       new Shoot(20, 1, 1, 0, coolDown: 2500, coolDownOffset: 0),
                    new Shoot(20, 1, 1, 0, coolDown: 2500, coolDownOffset: 250),
                    new Shoot(20, 1, 1, 0, coolDown: 2500, coolDownOffset: 500),
                    new Shoot(20, 1, 1, 0, coolDown: 2500, coolDownOffset: 750)
                         ),
                    new State("suicide",
                     new Suicide()
                          )))
        .Init("lod Blue Soul Flame",
                   new State(
                    new State("start",
                       new Shoot(20, 5, 30, 0, coolDown: 750, coolDownOffset: 0)
                         )))
        .Init("lod Red Soul Flame",
                   new State(
                    new State("start",
                       new Shoot(20, 5, 30, 0, coolDown: 750, coolDownOffset: 0)
                         )))
        .Init("lod Black Soul Flame",
                   new State(
                    new State("start",
                       new Shoot(20, 5, 30, 0, coolDown: 750, coolDownOffset: 0)
                         )))
        .Init("lod Green Soul Flame",
                   new State(
                    new State("start",
                       new Shoot(20, 5, 30, 0, coolDown: 750, coolDownOffset: 0)
                         )))
        .Init("lod White Dragon Orb",
                   new State(
                       new ConditionalEffect(ConditionEffectIndex.Invincible, true),
                    new State("start",
                       new Shoot(20, 12, 30, 0, 135, coolDown: 750, coolDownOffset: 0),
                       new TimedTransition(400, "start2")
                       ),
                       new State("start2",
                       new Shoot(20, 12, 30, 1, 90, coolDown: 750, coolDownOffset: 0),
                       new TimedTransition(400, "start")
                            ),
                       new State("suicide",
                       new Suicide()
                             )))
        .Init("lod Ivory Loot",
                   new State(
                    new State("idle",
                        new PlayerWithinTransition(15, "start")
                        ),
                    new State("start",
                        new ConditionalEffect(ConditionEffectIndex.Invulnerable, false),
                        new TimedTransition(5000, "Chest")
                         ),
                    new State("Chest",
                       new TimedTransition(500000, "start")
                        )

                ),
                new MostDamagers(1,
                    new ItemLoot("Potion of Attack", 0.25),
                    new ItemLoot("Potion of Attack", 0.25),
                    new ItemLoot("Potion of Dexterity", 0.5),
                    new ItemLoot("Rare Reptile Egg", 0.1)
                ),
                new Threshold(0.025,
                    new ItemLoot("Midnight Star", probability: 0.01),
                    new ItemLoot("Potion of Attack", 0.10),
                    new ItemLoot("Potion of Attack", 0.10),
                    new ItemLoot("Potion of Dexterity", 0.6),
                    new ItemLoot("Rare Reptile Egg", 0.05),
                    new TierLoot(6, ItemType.Ability, 0.13),
                    new TierLoot(12, ItemType.Armor, 0.175),
                    new TierLoot(4, ItemType.Ring, 0.15),
                    new TierLoot(13, ItemType.Armor, 0.125),
                    new TierLoot(11, ItemType.Weapon, 0.22),
                    new TierLoot(11, ItemType.Weapon, 0.11),
                    new TierLoot(5, ItemType.Ring, 0.05)
            ));
    }
}