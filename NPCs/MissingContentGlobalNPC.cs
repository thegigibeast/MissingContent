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
                case NPCID.Flocko:
                    if (Main.rand.Next(10) == 0)
                    {
                        target.AddBuff(BuffID.Chilled, 20 * 60);
                    }
                    break;

                case NPCID.FlyingSnake:
                    if (Main.rand.Next(10) == 0)
                    {
                        target.AddBuff(BuffID.Venom, 7 * 60);
                    }
                    break;

                case NPCID.GiantCursedSkull:
                    if (Main.rand.Next(3) == 0)
                    {
                        target.AddBuff(BuffID.Cursed, 6 * 60);
                    }
                    break;

                case NPCID.GiantFlyingFox:
                    if (Main.rand.Next(8) == 0)
                    {
                        target.AddBuff(BuffID.Bleeding, 30 * 60);
                    }
                    break;

                case NPCID.Hellhound:
                    if (Main.rand.Next(6) == 0)
                    {
                        target.AddBuff(BuffID.Darkness, 15 * 60);
                    }

                    if (Main.rand.Next(8) == 0)
                    {
                        target.AddBuff(BuffID.Bleeding, 40 * 60);
                    }
                    break;

                case NPCID.JungleCreeper:
                case NPCID.JungleCreeperWall:
                    if (Main.rand.Next(10) == 0)
                    {
                        target.AddBuff(BuffID.Venom, 6 * 60);
                    }
                    break;

                case NPCID.Poltergeist:
                    if (Main.rand.Next(10) == 0)
                    {
                        target.AddBuff(BuffID.Blackout, 2 * 60);
                    }
                    break;

                case NPCID.RustyArmoredBonesAxe:
                case NPCID.RustyArmoredBonesFlail:
                case NPCID.RustyArmoredBonesSword:
                case NPCID.RustyArmoredBonesSwordNoArmor:
                    if (Main.rand.Next(10) == 0)
                    {
                        target.AddBuff(BuffID.Weak, 60 * 60);
                    }
                    break;

                case NPCID.Splinterling:
                    if (Main.rand.Next(10) == 0)
                    {
                        target.AddBuff(BuffID.Bleeding, 30 * 60);
                    }
                    break;

                case NPCID.Yeti:
                    if (Main.rand.Next(3) == 0)
                    {
                        target.AddBuff(BuffID.BrokenArmor, 60 * 60);
                    }
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