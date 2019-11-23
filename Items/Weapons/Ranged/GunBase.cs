using Terraria.ID;

namespace MissingContent.Items.Weapons.Ranged
{
    public abstract class GunBase : ItemBase
    {
        #region Public Methods

        public virtual void SetGunDefaults()
        {
        }

        sealed public override void SetItemDefaults()
        {
            item.ranged = true;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.noMelee = true;
            item.UseSound = SoundID.Item11;
            item.shoot = ProjectileID.Bullet;
            item.useAmmo = AmmoID.Bullet;

            SetGunDefaults();
        }

        #endregion Public Methods
    }
}