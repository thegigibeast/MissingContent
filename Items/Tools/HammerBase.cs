using Terraria.ID;

namespace MissingContent.Items.Tools
{
    public abstract class HammerBase : ItemBase
    {
        #region Public Properties

        public abstract int Hammer { get; }

        #endregion Public Properties

        #region Public Methods

        public virtual void SetHammerDefaults()
        {
        }

        sealed public override void SetItemDefaults()
        {
            item.melee = true;
            item.hammer = Hammer;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;

            SetHammerDefaults();
        }

        #endregion Public Methods
    }
}