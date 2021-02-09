using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Microsoft.Xna.Framework;

namespace SmallVanityProject.Items
{
	[AutoloadEquip(EquipType.Head)]
	public class HweenMask : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			DisplayName.SetDefault("H'ween Mask");
			Tooltip.SetDefault("Aaaarrrghhh ... I'm a monster.");
			}
			
		public override void SetDefaults() {
			item.width = 28;
			item.height = 28;
			item.rare = ItemRarityID.Blue;
			item.vanity = true;
			item.value = Item.sellPrice(0, 0, 5, 0);
		}

		
	}
}
