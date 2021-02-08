using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Microsoft.Xna.Framework;

namespace SmallVanityProject.Items
{
	[AutoloadEquip(EquipType.HandsOn,EquipType.HandsOff)]
	class CrabClaw : ModItem
	{

		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			DisplayName.SetDefault("Crab Claw");
			Tooltip.SetDefault("Big, meaty claws!");
			}

		public override void SetDefaults()
		{
			item.accessory = true;
			item.width = 16;
			item.height = 20;
			item.rare = ItemRarityID.Blue;
			item.vanity = true;
			item.value = Item.sellPrice(0, 1, 50, 0);
		}
		
	}
}
