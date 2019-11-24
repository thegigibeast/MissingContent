using System.Collections.Generic;
using MissingContent.Extensions;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace MissingContent.Items
{
    public class MissingContentGlobalItem : GlobalItem
    {
        #region Public Methods

        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            var index = 0;

            switch (item.type)
            {
                case ItemID.AnkhCharm:
                case ItemID.AnkhShield:
                    index = tooltips.FindLastIndex(x => x.Name.Contains("Tooltip")) + 1;
                    tooltips.Insert(index, new TooltipLine(mod, "Tooltip", Language.GetTextValue("Mods.MissingContent.ItemTooltipAddition.AnkhCharm")));
                    break;

                case ItemID.Bezoar:
                case ItemID.MedicatedBandage:
                    index = tooltips.FindLastIndex(x => x.Name.Contains("Tooltip")) + 1;
                    tooltips.Insert(index, new TooltipLine(mod, "Tooltip", Language.GetTextValue("Mods.MissingContent.ItemTooltipAddition.Bezoar")));
                    break;

                case ItemID.Blindfold:
                    index = tooltips.FindLastIndex(x => x.Name.Contains("Tooltip")) + 1;
                    tooltips.Insert(index, new TooltipLine(mod, "Tooltip", Language.GetTextValue("Mods.MissingContent.ItemTooltipAddition.Blindfold")));
                    break;

                case ItemID.HandWarmer:
                    tooltips.Find(x => x.Name.Contains("Tooltip")).text = Language.GetTextValue("Mods.MissingContent.ItemTooltipAddition.HandWarmer");
                    break;

                case ItemID.LavaWaders:
                case ItemID.ObsidianHorseshoe:
                case ItemID.ObsidianShield:
                case ItemID.ObsidianSkull:
                case ItemID.ObsidianWaterWalkingBoots:
                    index = tooltips.FindLastIndex(x => x.Name.Contains("Tooltip")) + 1;
                    tooltips.Insert(index, new TooltipLine(mod, "Tooltip", Language.GetTextValue("Mods.MissingContent.ItemTooltipAddition.ObsidianSkull")));
                    break;
            }
        }

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
                case ItemID.AnkhCharm:
                    player.buffImmune[BuffID.Chilled] = true;
                    player.buffImmune[BuffID.Stoned] = true;
                    player.GetModPlayer<MissingContentPlayer>().blackoutResistance = true;
                    player.GetModPlayer<MissingContentPlayer>().venomResistance = true;
                    player.GetModPlayer<MissingContentPlayer>().frozenResistance = true;
                    break;

                case ItemID.AnkhShield:
                    player.buffImmune[BuffID.OnFire] = true;
                    player.buffImmune[BuffID.Stoned] = true;
                    player.GetModPlayer<MissingContentPlayer>().blackoutResistance = true;
                    player.GetModPlayer<MissingContentPlayer>().venomResistance = true;
                    player.GetModPlayer<MissingContentPlayer>().frozenResistance = true;
                    break;

                case ItemID.Bezoar:
                case ItemID.MedicatedBandage:
                    player.GetModPlayer<MissingContentPlayer>().venomResistance = true;
                    break;

                case ItemID.Blindfold:
                    player.GetModPlayer<MissingContentPlayer>().blackoutResistance = true;
                    break;

                case ItemID.HandWarmer:
                    player.buffImmune[BuffID.Frozen] = false;
                    player.GetModPlayer<MissingContentPlayer>().frozenResistance = true;
                    break;

                case ItemID.LavaWaders:
                case ItemID.ObsidianHorseshoe:
                case ItemID.ObsidianShield:
                case ItemID.ObsidianSkull:
                case ItemID.ObsidianWaterWalkingBoots:
                    player.buffImmune[BuffID.OnFire] = true;
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