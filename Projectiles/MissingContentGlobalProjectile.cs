using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MissingContent.Projectiles
{
    public class MissingContentGlobalProjectile : GlobalProjectile
    {
        #region Public Methods

        public override void ModifyHitPlayer(Projectile projectile, Player target, ref int damage, ref bool crit)
        {
            switch (projectile.type)
            {
                case ProjectileID.FlamingScythe:
                    if (Main.rand.Next(3) == 0)
                    {
                        target.AddBuff(BuffID.OnFire, 7 * 60);
                    }
                    break;

                case ProjectileID.FlamingWood:
                    if (Main.rand.Next(5) == 0)
                    {
                        target.AddBuff(BuffID.OnFire, 3 * 60);
                    }
                    break;

                case ProjectileID.GreekFire1:
                case ProjectileID.GreekFire2:
                case ProjectileID.GreekFire3:
                    if (Main.rand.Next(2) == 0)
                    {
                        target.AddBuff(BuffID.OnFire, 5 * 60);
                    }
                    break;

                case ProjectileID.Missile:
                    if (Main.rand.Next(5) == 0)
                    {
                        target.AddBuff(BuffID.OnFire, 3 * 60);
                    }
                    break;

                case ProjectileID.OrnamentHostileShrapnel:
                    if (Main.rand.Next(4) == 0)
                    {
                        target.AddBuff(BuffID.Bleeding, 20 * 60);
                    }
                    break;
            }
        }

        #endregion Public Methods
    }
}