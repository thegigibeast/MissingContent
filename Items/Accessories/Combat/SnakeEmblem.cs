using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MissingContent.Items.Accessories.Combat
{
    public class SnakeEmblem : AccessoryBase
    {
        #region Public Methods

        public override void AddRecipes()
        {
            var recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<SnakeEyes>());
            recipe.AddIngredient(ItemID.DestroyerEmblem);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override void SetAccessoryDefaults()
        {
            item.rare = ItemRarityID.Lime;
            item.value = Item.sellPrice(gold: 16);
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetModPlayer<MissingContentPlayer>().snakeEyes = true;
            player.meleeCrit += 10;
            player.rangedCrit += 10;
            player.magicCrit += 10;
            player.thrownCrit += 10;
            player.allDamage += 0.07f;
        }

        #endregion Public Methods
    }
}