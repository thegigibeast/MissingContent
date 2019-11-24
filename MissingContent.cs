using MissingContent.Extensions;
using MonoMod.Cil;
using System;
using Terraria;
using Terraria.ID;
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

            On.Terraria.Player.AddBuff += Player_AddBuff;
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

        private void Player_AddBuff(On.Terraria.Player.orig_AddBuff orig, Player self, int type, int time1, bool quiet)
        {
            var applyBuff = true;
            switch (type)
            {
                case BuffID.Blackout:
                    if (self.GetModPlayer<MissingContentPlayer>().blackoutResistance && Main.rand.Next(2) == 0)
                    {
                        applyBuff = false;
                    }
                    break;

                case BuffID.Frozen:
                    if (self.GetModPlayer<MissingContentPlayer>().frozenResistance && Main.rand.Next(2) == 0)
                    {
                        applyBuff = false;
                    }
                    break;

                case BuffID.Venom:
                    if (self.GetModPlayer<MissingContentPlayer>().venomResistance && Main.rand.Next(2) == 0)
                    {
                        applyBuff = false;
                    }
                    break;
            }

            if (applyBuff)
            {
                orig(self, type, time1, quiet);
            }
        }

        #endregion Private Methods
    }
}