namespace MissingContent.Items.Accessories
{
    public abstract class AccessoryBase : ItemBase
    {
        #region Public Methods

        public virtual void SetAccessoryDefaults()
        {
        }

        sealed public override void SetItemDefaults()
        {
            item.accessory = true;

            SetAccessoryDefaults();
        }

        #endregion Public Methods
    }
}