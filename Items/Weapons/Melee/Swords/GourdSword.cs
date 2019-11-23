using Terraria.ID;
using Terraria.ModLoader;

namespace MissingContent.Items.Weapons.Melee.Swords
{
    public class GourdSword : SwordBase
    {
        #region Public Methods

        public override void AddRecipes()
        {
            var recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Pumpkin, 12);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override void SetSwordDefaults()
        {
            item.damage = 15;
            item.useTime = 22;
            item.useAnimation = 22;
            item.knockBack = 5f;
        }

        #endregion Public Methods
    }
}