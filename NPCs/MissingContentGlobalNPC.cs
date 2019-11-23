using MissingContent.Items.Accessories.Combat;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MissingContent.NPCs
{
    public class MissingContentGlobalNPC : GlobalNPC
    {
        #region Public Methods

        public override void ModifyHitPlayer(NPC npc, Player target, ref int damage, ref bool crit)
        {
            switch (npc.type)
            {
                case NPCID.FlyingSnake:
                    // Inflicts Venom for 8 (16) seconds
                    var time = Main.expertMode ? 16 : 8;
                    target.AddBuff(BuffID.Venom, time * 60);
                    break;
            }
        }

        public override void NPCLoot(NPC npc)
        {
            switch (npc.type)
            {
                case NPCID.ArmoredViking:
                case NPCID.UndeadViking:
                    // 1% chance (2% in expert) to drop
                    var chance = Main.expertMode ? 50 : 100;
                    if (Main.rand.Next(chance) == 0)
                    {
                        Item.NewItem(npc.getRect(), ItemID.HandWarmer);
                    }
                    break;

                case NPCID.CursedSkull:
                    if (Main.rand.Next(75) == 0)
                    {
                        Item.NewItem(npc.getRect(), ModContent.ItemType<CursedBoneCharm>());
                    }
                    break;

                case NPCID.FlyingSnake:
                    if (Main.rand.Next(360) == 0)
                    {
                        Item.NewItem(npc.getRect(), ModContent.ItemType<SnakeEyes>());
                    }
                    break;
            }
        }

        #endregion Public Methods
    }
}