using MissingContent.Extensions;
using MissingContent.Utils;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MissingContent
{
    public class MissingContentPlayer : ModPlayer
    {
        #region Public Fields

        public bool blackoutResistance;
        public bool cursedBoneCharm;
        public bool frozenResistance;
        public bool snakeEyes;
        public bool venomResistance;

        #endregion Public Fields

        #region Public Methods

        public override void ModifyHitByNPC(NPC npc, ref int damage, ref bool crit)
        {
            if (cursedBoneCharm)
            {
                // Inflicts the debuff for 1-2 seconds
                npc.AddBuff(BuffID.Confused, Main.rand.Next(1, 3) * 60);
            }
        }

        public override void ModifyHitNPC(Item item, NPC target, ref int damage, ref float knockback, ref bool crit)
        {
            player.SnakeEyes(target, ref damage, crit);
        }

        public override void ModifyHitNPCWithProj(Projectile proj, NPC target, ref int damage, ref float knockback, ref bool crit, ref int hitDirection)
        {
            player.SnakeEyes(target, ref damage, crit);
        }

        public override void ModifyHitPvp(Item item, Player target, ref int damage, ref bool crit)
        {
            player.SnakeEyes(target, ref damage, crit);
        }

        public override void ModifyHitPvpWithProj(Projectile proj, Player target, ref int damage, ref bool crit)
        {
            player.SnakeEyes(target, ref damage, crit);
        }

        public override void ResetEffects()
        {
            blackoutResistance = false;
            cursedBoneCharm = false;
            frozenResistance = false;
            snakeEyes = false;
            venomResistance = false;
        }

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