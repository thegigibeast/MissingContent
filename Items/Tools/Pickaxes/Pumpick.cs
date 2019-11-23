using Terraria.ID;
using Terraria.ModLoader;

namespace MissingContent.Items.Tools.Pickaxes
{
    public class Pumpick : PickaxeBase
    {
        #region Public Properties

        public override int Pick => 55;

        #endregion Public Properties

        #region Public Methods

        public override void AddRecipes()
        {
            var recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Pumpkin, 15);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override void SetPickaxeDefaults()
        {
            item.damage = 7;
            item.useTime = 20;
            item.useAnimation = 20;
            item.knockBack = 2;
        }

        #endregion Public Methods
    }
}