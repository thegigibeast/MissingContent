using Terraria;
using Terraria.ID;

namespace MissingContent.Items.Accessories.Combat
{
    public class CursedBoneCharm : AccessoryBase
    {
        #region Public Methods

        public override void SetAccessoryDefaults()
        {
            item.rare = ItemRarityID.Green;
            item.value = Item.sellPrice(gold: 1, silver: 50);
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetModPlayer<MissingContentPlayer>().cursedBoneCharm = true;
        }

        #endregion Public Methods
    }
}