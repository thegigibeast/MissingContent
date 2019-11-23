using MissingContent.Items.Accessories.Combat;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MissingContent.NPCs
{
    public class MissingContentGlobalNPC : GlobalNPC
    {
        #region Public Methods

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
            }
        }

        #endregion Public Methods
    }
}