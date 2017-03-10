using Mono.Game;
using System;
using wServer.realm;

namespace wServer.logic.ProductionBehaviorsTransitions
{
    public class OnTile : Transition
    {
        private string[] floor;

        public OnTile(string targetState, params string[] floor)
            : base(targetState)
        {
            this.floor = floor;
        }

        protected override bool TickCore(Entity host, RealmTime time, ref object state)
        {
            bool ret = false;
            var tile = host.Owner.Map[(int)host.X, (int)host.Y];
            var words = host.Manager.GameData.IdToTileType[floor[Random.Next(floor.Length)]];
            if (tile.TileId == words)
            {
                ret = true;
            }
            return ret;
        }
    }
}
