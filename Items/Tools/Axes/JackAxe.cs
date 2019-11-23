using Terraria.ID;
using Terraria.ModLoader;

namespace MissingContent.Items.Tools.Axes
{
    public class JackAxe : AxeBase
    {
        #region Public Properties

        public override int Axe => 65;

        #endregion Public Properties

        #region Public Methods

        public override void AddRecipes()
        {
            var recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Pumpkin, 10);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override void SetAxeDefaults()
        {
            item.damage = 12;
            item.useTime = 33;
            item.useAnimation = 33;
            item.knockBack = 5f;
        }

        #endregion Public Methods
    }
}