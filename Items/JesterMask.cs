using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Microsoft.Xna.Framework;

namespace SmallVanityProject.Items
{
	[AutoloadEquip(EquipType.Head)]
	public class JesterMask : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			DisplayName.SetDefault("Jester's Mask");
			}
			
		public override void SetDefaults() {
			item.width = 16;
			item.height = 16;
			item.rare = ItemRarityID.Blue;
			item.vanity = true;
			item.value = Item.sellPrice(0, 1, 50, 0);
		}

		
	}
}
