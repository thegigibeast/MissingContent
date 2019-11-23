using Terraria.ModLoader;

namespace MissingContent.Items
{
    public abstract class ItemBase : ModItem
    {
        #region Public Methods

        sealed public override void SetDefaults()
        {
            // Automatically get width and height from the texture
            var texture = mod.GetTexture(Texture.Remove(0, mod.Name.Length + 1));
            item.width = texture.Width;
            item.height = texture.Height;

            SetItemDefaults();
        }

        public virtual void SetItemDefaults()
        {
        }

        #endregion Public Methods
    }
}