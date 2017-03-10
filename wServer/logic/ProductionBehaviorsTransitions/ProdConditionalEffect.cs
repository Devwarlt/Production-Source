using System;
using wServer.networking.svrPackets;
using wServer.realm;
using wServer.realm.entities;


namespace wServer.logic.ProductionBehaviorsTransitions
{
    public class ProdConditionalEffect : CycleBehavior
    {

        private readonly ConditionEffectIndex effect;
        private readonly bool perm;
        private readonly int duration;
        protected Cooldown coolDown;
        protected readonly int coolDownOffset;

        public ProdConditionalEffect(ConditionEffectIndex effect, bool perm = false, int duration = 0, int coolDownOffset = 0, Cooldown coolDown = new Cooldown())
        {
            this.effect = effect;
            this.perm = perm;
            this.duration = duration;
            this.coolDownOffset = coolDownOffset;
            this.coolDown = coolDown.Normalize();
        }

        protected override void OnStateEntry(Entity host, RealmTime time, ref object state) => state = coolDownOffset;

        protected override void TickCore(Entity host, RealmTime time, ref object state)
        {
            if (state == null) return;
            int cool = (int)state;
            Status = CycleStatus.NotStarted;
            if (cool <= 0)
            {
                host.ApplyConditionEffect(new ConditionEffect
                {
                    Effect = effect,
                    DurationMS = duration
                });
                cool = coolDown.Next(Random);
                Status = CycleStatus.Completed;
            }
            else
            {
                cool -= time.thisTickTimes;
                Status = CycleStatus.InProgress;
            }
            state = cool;
        }
    }
}