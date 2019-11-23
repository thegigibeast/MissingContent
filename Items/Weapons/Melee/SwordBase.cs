using Terraria.ID;

namespace MissingContent.Items.Weapons.Melee
{
    public abstract class SwordBase : ItemBase
    {
        #region Public Methods

        sealed public override void SetItemDefaults()
        {
            item.melee = true;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.UseSound = SoundID.Item1;

            SetSwordDefaults();
        }

        public virtual void SetSwordDefaults()
        {
        }

        #endregion Public Methods
    }
}