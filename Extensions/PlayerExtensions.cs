using System;
using Terraria;
using Terraria.ID;

namespace MissingContent.Utils
{
    public static class PlayerExtensions
    {
        #region Public Methods

        public static void SnakeEyes(this Player that, NPC target, ref int damage, bool crit)
        {
            if (that.GetModPlayer<MissingContentPlayer>().snakeEyes)
            {
                if (crit && Main.rand.Next(6) == 0)
                {
                    // Inflicts the debuff for 2-12 seconds
                    target.AddBuff(BuffID.Venom, Main.rand.Next(2, 13) * 60);
                }

                if (target.HasBuff(BuffID.Venom))
                {
                    // Increases damage by 12% if target has Venom
                    damage = (int)Math.Round(damage * 1.12f);
                }
            }
        }

        public static void SnakeEyes(this Player that, Player target, ref int damage, bool crit)
        {
            if (that.GetModPlayer<MissingContentPlayer>().snakeEyes)
            {
                if (crit && Main.rand.Next(6) == 0)
                {
                    // Inflicts the debuff for 2-12 seconds
                    target.AddBuff(BuffID.Venom, Main.rand.Next(2, 13) * 60);
                }

                if (target.HasBuff(BuffID.Venom))
                {
                    // Increases damage by 12% if target has Venom
                    damage = (int)Math.Round(damage * 1.12f);
                }
            }
        }

        #endregion Public Methods
    }
}