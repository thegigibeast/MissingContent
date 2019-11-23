using Terraria.ID;

namespace MissingContent.Items.Tools
{
    public abstract class PickaxeBase : ItemBase
    {
        #region Public Properties

        public abstract int Pick { get; }

        #endregion Public Properties

        #region Public Methods

        sealed public override void SetItemDefaults()
        {
            item.melee = true;
            item.pick = Pick;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;

            SetPickaxeDefaults();
        }

        public virtual void SetPickaxeDefaults()
        {
        }

        #endregion Public Methods
    }
}