using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Microsoft.Xna.Framework;

namespace SmallVanityProject.Items
{
	[AutoloadEquip(EquipType.Head)]
	public class LeafMask : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			DisplayName.SetDefault("Leaf Mask");
			}
			
		public override void SetDefaults() {
			item.width = 24;
			item.height = 30;
			item.rare = ItemRarityID.Blue;
			item.vanity = true;
			item.value = Item.sellPrice(0, 1, 50, 0);
		}

		
	}
}
