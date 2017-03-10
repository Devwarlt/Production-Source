#region

using wServer.logic.behaviors;
using wServer.logic.transitions;
using wServer.logic.loot;

#endregion

namespace wServer.logic
{
    partial class BehaviorDb
    {
        private _ UndeadLair = () => Behav()
            .Init("Septavius the Ghost God",
                new State(
                    new DropPortalOnDeath("Realm Portal", 100),
                    new State("check_ya",
                        new ConditionalEffect(ConditionEffectIndex.Invincible),
                        new PlayerWithinTransition(8, "1")
                        ),
                    new State("1",
                        new State("transition1",
                            new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                            new TimedTransition(3000, "spiral")
                            ),
                        new State("transition2",
                            new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                            new TimedTransition(3000, "ring")
                            ),
                        new State("transition3",
                            new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                            new TimedTransition(3000, "quiet")
                            ),
                        new State("transition4",
                            new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                            new Flash(0x00FF00, 0.25, 12),
                            new TimedTransition(3000, "spawn")
                            )
                        ),
                    new State("spiral",
                        new Wander(0.1),
                        new Spawn("Lair Ghost Archer", 1, 1),
                        new Spawn("Lair Ghost Knight", 2, 2),
                        new Spawn("Lair Ghost Mage", 1, 1),
                        new Spawn("Lair Ghost Rogue", 2, 2),
                        new Spawn("Lair Ghost Paladin", 1, 1),
                        new Spawn("Lair Ghost Warrior", 2, 2),
                        new Shoot(10, 3, fixedAngle: 0, coolDownOffset: 0, coolDown: 999999),
                        new Shoot(10, 3, fixedAngle: 24, coolDownOffset: 300, coolDown: 999999),
                        new Shoot(10, 3, fixedAngle: 48, coolDownOffset: 600, coolDown: 999999),
                        new Shoot(10, 3, fixedAngle: 72, coolDownOffset: 900, coolDown: 999999),
                        new Shoot(10, 3, fixedAngle: 96, coolDownOffset: 1200, coolDown: 999999),
                        new Shoot(10, 3, fixedAngle: 0, coolDownOffset: 1500, coolDown: 999999),
                        new Shoot(10, 3, fixedAngle: 24, coolDownOffset: 1900, coolDown: 999999),
                        new Shoot(10, 3, fixedAngle: 48, coolDownOffset: 2100, coolDown: 999999),
                        new Shoot(10, 3, fixedAngle: 72, coolDownOffset: 2400, coolDown: 999999),
                        new Shoot(10, 3, fixedAngle: 96, coolDownOffset: 2700, coolDown: 999999),
                        new Shoot(10, 3, fixedAngle: 0, coolDownOffset: 3000, coolDown: 999999),
                        new Shoot(10, 3, fixedAngle: 24, coolDownOffset: 3300, coolDown: 999999),
                        new Shoot(10, 3, fixedAngle: 48, coolDownOffset: 3600, coolDown: 999999),
                        new Shoot(10, 3, fixedAngle: 72, coolDownOffset: 3900, coolDown: 999999),
                        new Shoot(10, 3, fixedAngle: 96, coolDownOffset: 4200, coolDown: 999999),
                        new Shoot(10, 3, fixedAngle: 0, coolDownOffset: 4500, coolDown: 999999),
                        new Shoot(10, 3, fixedAngle: 24, coolDownOffset: 4800, coolDown: 999999),
                        new Shoot(10, 3, fixedAngle: 48, coolDownOffset: 5100, coolDown: 999999),
                        new Shoot(10, 3, fixedAngle: 72, coolDownOffset: 5400, coolDown: 999999),
                        new Shoot(10, 3, fixedAngle: 96, coolDownOffset: 5700, coolDown: 999999),
                        new Shoot(10, 3, fixedAngle: 0, coolDownOffset: 6000, coolDown: 999999),
                        new Shoot(10, 3, fixedAngle: 24, coolDownOffset: 6300, coolDown: 999999),
                        new Shoot(10, 3, fixedAngle: 48, coolDownOffset: 6600, coolDown: 999999),
                        new Shoot(10, 3, fixedAngle: 72, coolDownOffset: 6900, coolDown: 999999),
                        new Shoot(10, 3, fixedAngle: 96, coolDownOffset: 7200, coolDown: 999999),
                        new Shoot(10, 3, fixedAngle: 0, coolDownOffset: 7500, coolDown: 999999),
                        new Shoot(10, 3, fixedAngle: 24, coolDownOffset: 7800, coolDown: 999999),
                        new Shoot(10, 3, fixedAngle: 48, coolDownOffset: 8100, coolDown: 999999),
                        new Shoot(10, 3, fixedAngle: 72, coolDownOffset: 8400, coolDown: 999999),
                        new Shoot(10, 3, fixedAngle: 96, coolDownOffset: 8700, coolDown: 999999),
                        new Shoot(10, 3, fixedAngle: 0, coolDownOffset: 9000, coolDown: 999999),
                        new Shoot(10, 3, fixedAngle: 24, coolDownOffset: 9300, coolDown: 999999),
                        new Shoot(10, 3, fixedAngle: 48, coolDownOffset: 9600, coolDown: 999999),
                        new Shoot(10, 3, fixedAngle: 72, coolDownOffset: 9900, coolDown: 999999),
                        new TimedTransition(10000, "transition2"),
                        new State("Waiting_1",
                            new TimedTransition(2500, "Invulnerable_1")
                            ),
                        new State("Invulnerable_1",
                            new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                            new TimedTransition(1000, "Unset_Invulnerable_1")
                            ),
                        new State("Unset_Invulnerable_1",
                            new TimedTransition(2500, "Invulnerable_2")
                            ),
                        new State("Invulnerable_2",
                            new ConditionalEffect(ConditionEffectIndex.Invulnerable)
                            )
                        ),
                    new State("ring",
                        new Wander(0.3),
                        new Shoot(10, 12, projectileIndex: 3, coolDown: 2000),
                        new TimedTransition(10000, "transition3"),
                        new State("Waiting_2",
                            new TimedTransition(2500, "Invulnerable_2")
                            ),
                        new State("Invulnerable_2",
                            new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                            new TimedTransition(1000, "Unset_Invulnerable_2")
                            ),
                        new State("Unset_Invulnerable_2",
                            new TimedTransition(2500, "Invulnerable_3")
                            ),
                        new State("Invulnerable_3",
                            new ConditionalEffect(ConditionEffectIndex.Invulnerable)
                            )
                        ),
                    new State("quiet",
                        new Wander(0.1),
                        new Shoot(10, 8, projectileIndex: 1, coolDown: 1000),
                        new Shoot(10, 8, projectileIndex: 1, coolDownOffset: 500, angleOffset: 22.5, coolDown: 999999),
                        new Shoot(10, 8, projectileIndex: 1, coolDownOffset: 1500, angleOffset: 22.5, coolDown: 999999),
                        new Shoot(10, 8, projectileIndex: 1, coolDownOffset: 2500, angleOffset: 22.5, coolDown: 999999),
                        new Shoot(10, 8, projectileIndex: 1, coolDownOffset: 3500, angleOffset: 22.5, coolDown: 999999),
                        new Shoot(10, 8, projectileIndex: 1, coolDownOffset: 4500, angleOffset: 22.5, coolDown: 999999),
                        new Shoot(10, 8, projectileIndex: 1, coolDownOffset: 5500, angleOffset: 22.5, coolDown: 999999),
                        new Shoot(10, 8, projectileIndex: 1, coolDownOffset: 6500, angleOffset: 22.5, coolDown: 999999),
                        new Shoot(10, 8, projectileIndex: 1, coolDownOffset: 7500, angleOffset: 22.5, coolDown: 999999),
                        new Shoot(10, 8, projectileIndex: 1, coolDownOffset: 8500, angleOffset: 22.5, coolDown: 999999),
                        new Shoot(10, 8, projectileIndex: 1, coolDownOffset: 9500, angleOffset: 22.5, coolDown: 999999),
                        new Shoot(8, 3, shootAngle: 20, projectileIndex: 2, coolDown: 2000),
                        new TimedTransition(10000, "transition4"),
                        new State("Waiting_3",
                            new TimedTransition(2500, "Invulnerable_3")
                            ),
                        new State("Invulnerable_3",
                            new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                            new TimedTransition(1000, "Unset_Invulnerable_3")
                            ),
                        new State("Unset_Invulnerable_3",
                            new TimedTransition(2500, "Invulnerable_4")
                            ),
                        new State("Invulnerable_4",
                            new ConditionalEffect(ConditionEffectIndex.Invulnerable)
                            )
                        ),
                    new State("spawn",
                        new Wander(0.1),
                        new Spawn("Ghost Mage of Septavius", 2, 0),
                        new Spawn("Ghost Rogue of Septavius", 2, 0),
                        new Spawn("Ghost Warrior of Septavius", 2, 0),
                        new Reproduce("Ghost Mage of Septavius", densityMax: 2, coolDown: 1000, spawnRadius: 0),
                        new Reproduce("Ghost Rogue of Septavius", densityMax: 2, coolDown: 1000, spawnRadius: 0),
                        new Reproduce("Ghost Warrior of Septavius", densityMax: 2, coolDown: 1000, spawnRadius: 0),
                        new Shoot(8, 3, shootAngle: 10, projectileIndex: 4, coolDown: 1000),
                        new TimedTransition(10000, "transition1"),
                        new State("Waiting_4",
                            new TimedTransition(2500, "Invulnerable_4")
                            ),
                        new State("Invulnerable_4",
                            new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                            new TimedTransition(1000, "Unset_Invulnerable_4")
                            ),
                        new State("Unset_Invulnerable_4",
                            new TimedTransition(2500, "Invulnerable_5")
                            ),
                        new State("Invulnerable_5",
                            new ConditionalEffect(ConditionEffectIndex.Invulnerable)
                            )
                        )
                    ),
                new MostDamagers(3,
                    new ItemLoot("Potion of Wisdom", 1)
                    ),
                new Threshold(0.01,
                    new ItemLoot("Bow of the Morning Star", 0.01),
                    new ItemLoot("Doom Bow", 0.01),
                    new ItemLoot("Wine Cellar Incantation", 0.05),
                    new TierLoot(3, ItemType.Ring, 0.1),
                    new TierLoot(4, ItemType.Ring, 0.06),
                    new TierLoot(7, ItemType.Weapon, 0.1),
                    new TierLoot(8, ItemType.Weapon, 0.06),
                    new TierLoot(3, ItemType.Ability, 0.15),
                    new TierLoot(4, ItemType.Ability, 0.1),
                    new TierLoot(5, ItemType.Ability, 0.06)
                    )
            )
            .Init("Ghost Mage of Septavius",
                new State(
                    new Prioritize(
                        new Protect(0.625, "Septavius the Ghost God", protectionRange: 6),
                        new Follow(0.75, range: 7)
                        ),
                    new Wander(0.25),
                    new Shoot(8, 1, coolDown: 1000)
                    ),
                new Threshold(0.01,
                    new ItemLoot("Health Potion", 0.25),
                    new ItemLoot("Magic Potion", 0.25)
                    )
            )
            .Init("Ghost Rogue of Septavius",
                new State(
                    new Follow(0.75, range: 1),
                    new Wander(0.25),
                    new Shoot(8, 1, coolDown: 1000)
                    ),
                new Threshold(0.01,
                    new ItemLoot("Health Potion", 0.25),
                    new ItemLoot("Magic Potion", 0.25)
                    )
            )
            .Init("Ghost Warrior of Septavius",
                new State(
                    new Follow(0.75, range: 1),
                    new Wander(0.25),
                    new Shoot(8, 1, coolDown: 1000)
                    ),
                new Threshold(0.01,
                    new ItemLoot("Health Potion", 0.25),
                    new ItemLoot("Magic Potion", 0.25)
                    )
            )
            .Init("Lair Ghost Archer",
                new State(
                    new Prioritize(
                        new Protect(0.625, "Septavius the Ghost God", protectionRange: 6),
                        new Follow(0.75, range: 7)
                        ),
                    new Wander(0.25),
                    new Shoot(8, 1, coolDown: 1000)
                    ),
                new Threshold(0.01,
                    new ItemLoot("Health Potion", 0.25),
                    new ItemLoot("Magic Potion", 0.25)
                    )
            )
            .Init("Lair Ghost Knight",
                new State(
                    new Follow(0.75, range: 1),
                    new Wander(0.25),
                    new Shoot(8, 1, coolDown: 1000)
                    ),
                new Threshold(0.01,
                    new ItemLoot("Health Potion", 0.25),
                    new ItemLoot("Magic Potion", 0.25)
                    )
            )
            .Init("Lair Ghost Mage",
                new State(
                    new Prioritize(
                        new Protect(0.625, "Septavius the Ghost God", protectionRange: 6),
                        new Follow(0.75, range: 7)
                        ),
                    new Wander(0.25),
                    new Shoot(8, 1, coolDown: 1000)
                    ),
                new Threshold(0.01,
                    new ItemLoot("Health Potion", 0.25),
                    new ItemLoot("Magic Potion", 0.25)
                    )
            )
            .Init("Lair Ghost Paladin",
                new State(
                    new Follow(0.75, range: 1),
                    new Wander(0.25),
                    new Shoot(8, 1, coolDown: 1000),
                    new Heal(5, "Lair Ghosts", 5000)
                    ),
                new Threshold(0.01,
                    new ItemLoot("Health Potion", 0.25),
                    new ItemLoot("Magic Potion", 0.25)
                    )
            )
            .Init("Lair Ghost Rogue",
                new State(
                    new Follow(0.75, range: 1),
                    new Wander(0.25),
                    new Shoot(8, 1, coolDown: 1000)
                    ),
                new Threshold(0.01,
                    new ItemLoot("Health Potion", 0.25),
                    new ItemLoot("Magic Potion", 0.25)
                    )
            )
            .Init("Lair Ghost Warrior",
                new State(
                    new Follow(0.75, range: 1),
                    new Wander(0.25),
                    new Shoot(8, 1, coolDown: 1000)
                    ),
                new Threshold(0.01,
                    new ItemLoot("Health Potion", 0.25),
                    new ItemLoot("Magic Potion", 0.25)
                    )
            )

            .Init("Lair Skeleton",
                new State(
                    new Shoot(6),
                    new Prioritize(
                        new Follow(1, range: 1),
                        new Wander(0.4)
                        )
                    ),
                new Threshold(0.01,
                    new ItemLoot("Health Potion", 0.05),
                    new ItemLoot("Magic Potion", 0.05)
                    )
            )
            .Init("Lair Skeleton King",
                new State(
                    new Shoot(10, 3, shootAngle: 10),
                    new Prioritize(
                        new Follow(1, range: 7),
                        new Wander(0.4)
                        )
                    ),
                new Threshold(0.01,
                    new TierLoot(6, ItemType.Weapon, 0.2),
                    new TierLoot(7, ItemType.Weapon, 0.1),
                    new TierLoot(8, ItemType.Weapon, 0.05),
                    new TierLoot(5, ItemType.Armor, 0.2),
                    new TierLoot(6, ItemType.Armor, 0.1),
                    new TierLoot(7, ItemType.Armor, 0.05),
                    new TierLoot(3, ItemType.Ring, 0.1),
                    new TierLoot(3, ItemType.Ability, 0.1)
                    )
            )
            .Init("Lair Skeleton Mage",
                new State(
                    new Shoot(10),
                    new Prioritize(
                        new Follow(1, range: 7),
                        new Wander(0.4)
                        )
                    ),
                new Threshold(0.01,
                    new ItemLoot("Health Potion", 0.05),
                    new ItemLoot("Magic Potion", 0.05)
                    )
            )
            .Init("Lair Skeleton Swordsman",
                new State(
                    new Shoot(5),
                    new Prioritize(
                        new Follow(1, range: 1),
                        new Wander(0.4)
                        )
                    ),
                new Threshold(0.01,
                    new ItemLoot("Health Potion", 0.05),
                    new ItemLoot("Magic Potion", 0.05)
                    )
            )
            .Init("Lair Skeleton Veteran",
                new State(
                    new Shoot(5),
                    new Prioritize(
                        new Follow(1, range: 1),
                        new Wander(0.4)
                        )
                    ),
                new Threshold(0.01,
                    new ItemLoot("Health Potion", 0.05),
                    new ItemLoot("Magic Potion", 0.05)
                    )
            )
            .Init("Lair Mummy",
                new State(
                    new Shoot(10),
                    new Prioritize(
                        new Follow(0.9, range: 7),
                        new Wander(0.4)
                        )
                    ),
                new Threshold(0.01,
                    new ItemLoot("Health Potion", 0.05),
                    new ItemLoot("Magic Potion", 0.05)
                    )
            )
            .Init("Lair Mummy King",
                new State(
                    new Shoot(10),
                    new Prioritize(
                        new Follow(0.9, range: 7),
                        new Wander(0.4)
                        )
                    ),
                new Threshold(0.01,
                    new ItemLoot("Health Potion", 0.05),
                    new ItemLoot("Magic Potion", 0.05)
                    )
            )
            .Init("Lair Mummy Pharaoh",
                new State(
                    new Shoot(10),
                    new Prioritize(
                        new Follow(0.9, range: 7),
                        new Wander(0.4)
                        )
                    ),
                new Threshold(0.01,
                    new TierLoot(6, ItemType.Weapon, 0.2),
                    new TierLoot(7, ItemType.Weapon, 0.1),
                    new TierLoot(8, ItemType.Weapon, 0.05),
                    new TierLoot(5, ItemType.Armor, 0.2),
                    new TierLoot(6, ItemType.Armor, 0.1),
                    new TierLoot(7, ItemType.Armor, 0.05),
                    new TierLoot(3, ItemType.Ring, 0.1),
                    new TierLoot(3, ItemType.Ability, 0.1)
                    )
            )

            .Init("Lair Big Brown Slime",
                new State(
                    new Shoot(10, 3, shootAngle: 10, coolDown: 500),
                    new Wander(0.1),
                    new TransformOnDeath("Lair Little Brown Slime", 6, 6, 1.0)
                    )
            )
            .Init("Lair Little Brown Slime",
                new State(
                    new Shoot(10, 3, shootAngle: 10, coolDown: 500),
                    new Protect(0.1, "Lair Big Brown Slime", acquireRange: 5, protectionRange: 2),
                    new Wander(0.1)
                    ),
                new Threshold(0.01,
                    new ItemLoot("Health Potion", 0.05),
                    new ItemLoot("Magic Potion", 0.05)
                    )
            )
            .Init("Lair Big Black Slime",
                new State(
                    new Shoot(10, coolDown: 1000),
                    new Wander(0.1),
                    new TransformOnDeath("Lair Medium Black Slime", 4, 4, 1.0)
                    )
            )
            .Init("Lair Medium Black Slime",
                new State(
                    new Shoot(10, coolDown: 1000),
                    new Wander(0.1),
                    new TransformOnDeath("Lair Little Black Slime", 4, 4, 1.0)
                    )
            )
            .Init("Lair Little Black Slime",
                new State(
                    new Shoot(10, coolDown: 1000),
                    new Wander(0.1)
                    ),
                new Threshold(0.01,
                    new ItemLoot("Health Potion", 0.05),
                    new ItemLoot("Magic Potion", 0.05)
                    )
            )

            .Init("Lair Construct Giant",
                new State(
                    new Prioritize(
                        new Follow(0.8, range: 7),
                        new Wander(0.4)
                        ),
                    new Shoot(10, 3, shootAngle: 20, coolDown: 1000),
                    new Shoot(10, projectileIndex: 1, coolDown: 1000)
                    ),
                new Threshold(0.01,
                    new TierLoot(6, ItemType.Weapon, 0.2),
                    new TierLoot(7, ItemType.Weapon, 0.1),
                    new TierLoot(8, ItemType.Weapon, 0.05),
                    new TierLoot(5, ItemType.Armor, 0.2),
                    new TierLoot(6, ItemType.Armor, 0.1),
                    new TierLoot(7, ItemType.Armor, 0.05),
                    new TierLoot(3, ItemType.Ring, 0.1),
                    new TierLoot(3, ItemType.Ability, 0.1)
                    )
            )
            .Init("Lair Construct Titan",
                new State(
                    new Prioritize(
                        new Follow(0.8, range: 7),
                        new Wander(0.4)
                        ),
                    new Shoot(10, 3, shootAngle: 20, coolDown: 1000),
                    new Shoot(10, 3, shootAngle: 20, projectileIndex: 1, coolDownOffset: 100, coolDown: 2000)
                    ),
                new Threshold(0.01,
                    new TierLoot(6, ItemType.Weapon, 0.2),
                    new TierLoot(7, ItemType.Weapon, 0.1),
                    new TierLoot(8, ItemType.Weapon, 0.05),
                    new TierLoot(5, ItemType.Armor, 0.2),
                    new TierLoot(6, ItemType.Armor, 0.1),
                    new TierLoot(7, ItemType.Armor, 0.05),
                    new TierLoot(3, ItemType.Ring, 0.1),
                    new TierLoot(3, ItemType.Ability, 0.1)
                    )
            )

            .Init("Lair Brown Bat",
                new State(
                    new Wander(0.1),
                    new Charge(3, 8, 2000),
                    new Shoot(3, coolDown: 1000)
                    ),
                new Threshold(0.01,
                    new ItemLoot("Health Potion", 0.05),
                    new ItemLoot("Magic Potion", 0.05)
                    )
            )
            .Init("Lair Ghost Bat",
                new State(
                    new Wander(0.1),
                    new Charge(3, 8, 2000),
                    new Shoot(3, coolDown: 1000)
                    ),
                new Threshold(0.01,
                    new ItemLoot("Health Potion", 0.05),
                    new ItemLoot("Magic Potion", 0.05)
                    )
            )

            .Init("Lair Reaper",
                new State(
                    new Shoot(3),
                    new Follow(1.3, range: 1),
                    new Wander(0.1)
                    ),
                new Threshold(0.01,
                    new TierLoot(6, ItemType.Weapon, 0.2),
                    new TierLoot(7, ItemType.Weapon, 0.1),
                    new TierLoot(8, ItemType.Weapon, 0.05),
                    new TierLoot(5, ItemType.Armor, 0.2),
                    new TierLoot(6, ItemType.Armor, 0.1),
                    new TierLoot(7, ItemType.Armor, 0.05),
                    new TierLoot(3, ItemType.Ring, 0.1),
                    new TierLoot(3, ItemType.Ability, 0.1)
                    )
            )
            .Init("Lair Vampire",
                new State(
                    new Shoot(10, coolDown: 500),
                    new Shoot(3, coolDown: 1000),
                    new Follow(1.3, range: 1),
                    new Wander(0.1)
                    ),
                new Threshold(0.01,
                    new ItemLoot("Health Potion", 0.05),
                    new ItemLoot("Magic Potion", 0.05)
                    )
            )
            .Init("Lair Vampire King",
                new State(
                    new Shoot(10, coolDown: 500),
                    new Shoot(3, coolDown: 1000),
                    new Follow(1.3, range: 1),
                    new Wander(0.1)
                    ),
                new Threshold(0.01,
                    new TierLoot(6, ItemType.Weapon, 0.2),
                    new TierLoot(7, ItemType.Weapon, 0.1),
                    new TierLoot(8, ItemType.Weapon, 0.05),
                    new TierLoot(5, ItemType.Armor, 0.2),
                    new TierLoot(6, ItemType.Armor, 0.1),
                    new TierLoot(7, ItemType.Armor, 0.05),
                    new TierLoot(3, ItemType.Ring, 0.1),
                    new TierLoot(3, ItemType.Ability, 0.1)
                    )
            )

            .Init("Lair Grey Spectre",
                new State(
                    new Wander(0.1),
                    new Shoot(10, coolDown: 1000),
                    new Grenade(2.5, 50, 8, coolDown: 1000)
                    )
            )
            .Init("Lair Blue Spectre",
                new State(
                    new Wander(0.1),
                    new Shoot(10, coolDown: 1000),
                    new Grenade(2.5, 70, 8, coolDown: 1000)
                    )
            )
            .Init("Lair White Spectre",
                new State(
                    new Wander(0.1),
                    new Shoot(10, coolDown: 1000),
                    new Grenade(2.5, 90, 8, coolDown: 1000)
                    ),
                new Threshold(0.01,
                    new TierLoot(4, ItemType.Ability, 0.15)
                    )
            )
            .Init("Lair Burst Trap",
                new State(
                    new State("Idle",
                        new PlayerWithinTransition(4, "Die baybe")
                        ),
                    new State("Die baybe",
                        new Shoot(999, 12, 30, 0, 0),
                        new Suicide()
                        )
                    )
            )
            .Init("Lair Blast Trap",
                new State(
                    new State("Idle",
                        new PlayerWithinTransition(4, "Die baybe")
                        ),
                    new State("Die baybe",
                        new Shoot(999, 6, 15, 0),
                        new Suicide()
                        )
                    )
            )
            ;
    }
}
