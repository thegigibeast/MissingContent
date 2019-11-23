using MissingContent.Extensions;
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

        public override void UpdateInventory(Item item, Player player)
        {
            // Apply effects of the item if it is a favorited Music Box
            if (item.favorited && item.IsMusicBox())
            {
                var wallSpeedBuff = false;
                var tileSpeedBuff = false;
                var tileRangeBuff = false;

                player.VanillaUpdateEquip(item);
                player.VanillaUpdateAccessory(player.whoAmI, item, false, ref wallSpeedBuff, ref tileSpeedBuff, ref tileRangeBuff);
            }
        }

        #endregion Public Methods
    }
}