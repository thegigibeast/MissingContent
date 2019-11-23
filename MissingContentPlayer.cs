using MissingContent.Extensions;
using Terraria.ModLoader;

namespace MissingContent
{
    public class MissingContentPlayer : ModPlayer
    {
        #region Public Methods

        public override void UpdateEquips(ref bool wallSpeedBuff, ref bool tileSpeedBuff, ref bool tileRangeBuff)
        {
            // Loops through the vanity accessory slots
            for (var i = 0; i < 18 + player.extraAccessorySlots; i++)
            {
                var item = player.armor[i];

                // Apply effects if the item is a music box
                if (item.IsMusicBox())
                {
                    player.VanillaUpdateEquip(item);
                    player.VanillaUpdateAccessory(player.whoAmI, item, false, ref wallSpeedBuff, ref tileSpeedBuff, ref tileRangeBuff);
                }
            }
        }

        #endregion Public Methods
    }
}