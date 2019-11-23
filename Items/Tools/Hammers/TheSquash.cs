using Terraria.ID;
using Terraria.ModLoader;

namespace MissingContent.Items.Tools.Hammers
{
    public class TheSquash : HammerBase
    {
        #region Public Properties

        public override int Hammer => 60;

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

        public override void SetHammerDefaults()
        {
            item.damage = 11;
            item.useTime = 30;
            item.useAnimation = 30;
            item.knockBack = 6f;
        }

        #endregion Public Methods
    }
}