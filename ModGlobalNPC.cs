using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using SmallVanityProject.Items;

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
            
            if (Main.rand.Next(50) == 0)
            {
                if (npc.type == NPCID.Crab)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("CrabClaw"));
                }
            }
            
             if (Main.rand.Next(50) == 0)
            {
                if (npc.type == NPCID.StardustWormBody)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("MilkywayScarf"));
                }
            }
            
                         if (Main.rand.Next(50) == 0)
            {
                if (npc.type == NPCID.StardustCellBig)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("StarCell"));
                }
                }
                
                if (Main.rand.Next(50) == 0)
                {
		 if (npc.type == NPCID.StardustCellSmall)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("StarCell"));
                }
                }
            }
        
        public override void SetupShop(int type, Chest shop, ref int nextSlot) {
		if (type == NPCID.Merchant) {
			shop.item[nextSlot].SetDefaults(ModContent.ItemType<LarupiaHat>(), false);
			nextSlot++;
		}
		else if (type == NPCID.Clothier) {
			shop.item[nextSlot].SetDefaults(ModContent.ItemType<GnomeChild>(), false);
			nextSlot++;
			shop.item[nextSlot].SetDefaults(ModContent.ItemType<HweenMask>(), false);
			nextSlot++;
		}
	}
    }
 }
