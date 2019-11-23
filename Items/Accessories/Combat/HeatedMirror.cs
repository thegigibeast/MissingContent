using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MissingContent.Items.Accessories.Combat
{
    public class HeatedMirror : AccessoryBase
    {
        #region Public Methods

        public override void AddRecipes()
        {
            var recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.PocketMirror);
            recipe.AddIngredient(ItemID.HandWarmer);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this);
            recipe.AddRecipe();

            // Add this item to Ankh Charm's recipes
            var finder = new RecipeFinder();
            finder.SetResult(ItemID.AnkhCharm);
            var recipes = finder.SearchRecipes();
            recipes.ForEach(x =>
            {
                var editor = new RecipeEditor(x);
                editor.AddIngredient(ModContent.ItemType<HeatedMirror>());
            });
        }

        public override void SetAccessoryDefaults()
        {
            item.rare = ItemRarityID.Pink;
            item.value = Item.sellPrice(gold: 2);
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.buffImmune[BuffID.Chilled] = true;
            player.buffImmune[BuffID.Frozen] = true;
            player.buffImmune[BuffID.Stoned] = true;
        }

        #endregion Public Methods
    }
}