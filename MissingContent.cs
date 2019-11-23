using MissingContent.Extensions;
using MonoMod.Cil;
using System;
using Terraria;
using Terraria.ModLoader;

namespace MissingContent
{
    public class MissingContent : Mod
    {
        #region Public Constructors

        public MissingContent()
        {
        }

        #endregion Public Constructors

        #region Public Properties

        // Mod Helpers integration
        public static string GithubProjectName => "MissingContent";

        public static string GithubUserName => "thegigibeast";

        #endregion Public Properties

        #region Public Methods

        public override void Load()
        {
            IL.Terraria.UI.ItemSlot.MouseHover_ItemArray_int_int += ItemSlot_MouseHover_ItemArray_int_int;
        }

        #endregion Public Methods

        #region Private Methods

        private void ItemSlot_MouseHover_ItemArray_int_int(ILContext il)
        {
            var c = new ILCursor(il);

            // Shows the regular tooltip for music boxes when they are equipped in vanity slots
            c.Goto(0);
            if (c.TryGotoNext(x => x.MatchStfld(typeof(Item), nameof(Item.social))))
            {
                c.Index--;
                c.Remove();
                c.EmitDelegate<Func<bool>>(() =>
                {
                    return !(Main.HoverItem.IsMusicBox());
                });
            }
        }

        #endregion Private Methods
    }
}