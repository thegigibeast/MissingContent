using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MissingContent.Items
{
    public class MissingContentGlobalItem : GlobalItem
    {
        #region Public Methods

        public override bool PreOpenVanillaBag(string context, Player player, int arg)
        {
            switch (context)
            {
                // Prevents the Hand Warmer from dropping from presents, will be cleared
                // automatically at the end of OpenVanillaBag
                case "present":
                    NPCLoader.blockLoot.Add(ItemID.HandWarmer);
                    break;
            }

            return base.PreOpenVanillaBag(context, player, arg);
        }

        public override void UpdateAccessory(Item item, Player player, bool hideVisual)
        {
            switch (item.type)
            {
                // Adds the Heated Mirror immunities to the items it is crafted into
                case ItemID.AnkhCharm:
                case ItemID.AnkhShield:
                    player.buffImmune[BuffID.Chilled] = true;
                    player.buffImmune[BuffID.Frozen] = true;
                    player.buffImmune[BuffID.Stoned] = true;
                    break;
            }
        }

        #endregion Public Methods
    }
}