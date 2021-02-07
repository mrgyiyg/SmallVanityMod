using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SmallVanityProject
{
public class ModGlobalNPC : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {
            if (Main.rand.Next(50) == 0)
            {
                if (npc.type == NPCID.StardustSpiderBig)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("TwinklePopperMask"));
                }
            }
            
            if (Main.rand.Next(50) == 0)
            {
                if (npc.type == NPCID.StardustJellyfishBig)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("FlowInvaderShard"));
                }
            }
            
            if (Main.rand.Next(50) == 0)
            {
                if (npc.type == NPCID.ToxicSludge)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ToxicSludgeMask"));
                }
            }
        }
    }
}
