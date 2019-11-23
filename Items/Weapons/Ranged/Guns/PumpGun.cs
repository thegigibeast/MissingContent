using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MissingContent.Items.Weapons.Ranged.Guns
{
    public class PumpGun : GunBase
    {
        #region Public Methods

        public override void AddRecipes()
        {
            var recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Pumpkin, 15);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(5f, 0f);
        }

        public override void SetGunDefaults()
        {
            item.damage = 10;
            item.useTime = 45;
            item.useAnimation = 45;
            item.knockBack = 0f;
            item.shootSpeed = 4.5f;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            // Fires two bullets
            for (var i = 0; i < 2; i++)
            {
                Projectile.NewProjectile(position, new Vector2(speedX, speedY), type, damage, knockBack, player.whoAmI);
            }

            return false;
        }

        #endregion Public Methods
    }
}