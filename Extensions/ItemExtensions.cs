using Terraria;
using Terraria.ID;

namespace MissingContent.Extensions
{
    public static class ItemExtensions
    {
        #region Public Methods

        public static bool IsMusicBox(this Item that) => (that.accessory && that.createTile > 0) || that.type == ItemID.MusicBox;

        #endregion Public Methods
    }
}