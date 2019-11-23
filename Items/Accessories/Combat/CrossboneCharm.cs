using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MissingContent.Items.Accessories.Combat
{
    public class CrossboneCharm : AccessoryBase
    {
        #region Public Methods

        public override void AddRecipes()
        {
            var recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.CrossNecklace);
            recipe.AddIngredient(ModContent.ItemType<CursedBoneCharm>());
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override void SetAccessoryDefaults()
        {
            item.rare = ItemRarityID.LightRed;
            item.value = Item.sellPrice(gold: 1, silver: 53);
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.longInvince = true;
            player.GetModPlayer<MissingContentPlayer>().cursedBoneCharm = true;
        }

        #endregion Public Methods
    }
}