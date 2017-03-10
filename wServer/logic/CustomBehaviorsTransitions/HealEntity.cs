﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using wServer.realm;
using wServer.realm.entities;
using wServer.networking.svrPackets;

namespace wServer.logic.CustomBehaviorsTransitions
{
    class HealEntity : Behavior
    {
        //State storage: cooldown timer

        private readonly double _range;
        private readonly string _name;
        private Cooldown _coolDown;
        private readonly int? _amount;

        public HealEntity(double range, string name, int? healAmount = null, Cooldown coolDown = new Cooldown())
        {
            _range = (float)range;
            _name = name;
            _coolDown = coolDown.Normalize();
            _amount = healAmount;
        }

        protected override void OnStateEntry(Entity host, RealmTime time, ref object state) => state = 0;


        protected override void TickCore(Entity host, RealmTime time, ref object state)
        {
            var cool = (int)state;

            if (cool <= 0)
            {
                if (host.HasConditionEffect(ConditionEffects.Stunned)) return;

                foreach (var entity in host.GetNearestEntitiesByName(_range, _name).OfType<Enemy>())
                {
                    int newHp = (int)entity.ObjectDesc.MaxHP;
                    if (_amount != null)
                    {
                        var newHealth = (int)_amount + entity.HP;
                        if (newHp > newHealth)
                            newHp = newHealth;
                    }
                    if (newHp != entity.HP)
                    {
                        int n = newHp - entity.HP;
                        entity.HP = newHp;
                        entity.Owner.BroadcastPacketNearby(new ShowEffectPacket()
                        {
                            EffectType = EffectType.Potion,
                            TargetId = entity.Id,
                            Color = new ARGB(0xffffffff)
                        }, entity, null);
                        entity.Owner.BroadcastPacketNearby(new ShowEffectPacket()
                        {
                            EffectType = EffectType.Trail,
                            TargetId = host.Id,
                            PosA = new Position() { X = entity.X, Y = entity.Y },
                            Color = new ARGB(0xffffffff)
                        }, host, null);
                        entity.Owner.BroadcastPacketNearby(new NotificationPacket()
                        {
                            ObjectId = entity.Id,
                            Text = "+" + n,
                            Color = new ARGB(0xff00ff00)
                        }, entity, null);
                    }
                }
                cool = _coolDown.Next(Random);
            }
            else
                cool -= time.thisTickTimes;

            state = cool;
        }
    }
}
