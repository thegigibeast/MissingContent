using Terraria.ID;

namespace MissingContent.Items.Tools
{
    public abstract class AxeBase : ItemBase
    {
        #region Public Properties

        public abstract int Axe { get; }

        #endregion Public Properties

        #region Public Methods

        public virtual void SetAxeDefaults()
        {
        }

        sealed public override void SetItemDefaults()
        {
            item.melee = true;
            item.axe = Axe / 5;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;

            SetAxeDefaults();
        }

        #endregion Public Methods
    }
}