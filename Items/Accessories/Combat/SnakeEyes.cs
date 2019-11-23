using Terraria;
using Terraria.ID;

namespace MissingContent.Items.Accessories.Combat
{
    public class SnakeEyes : AccessoryBase
    {
        #region Public Methods

        public override void SetAccessoryDefaults()
        {
            item.rare = ItemRarityID.Lime;
            item.value = Item.sellPrice(gold: 10);
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetModPlayer<MissingContentPlayer>().snakeEyes = true;
        }

        #endregion Public Methods
    }
}