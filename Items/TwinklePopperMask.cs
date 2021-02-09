using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Microsoft.Xna.Framework;

namespace SmallVanityProject.Items
{
	[AutoloadEquip(EquipType.Head)]
	public class TwinklePopperMask : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			DisplayName.SetDefault("Twinkle Popper Mask");
			}
			
		public override void SetDefaults() {
			item.width = 38;
			item.height = 32;
			item.rare = ItemRarityID.Blue;
			item.vanity = true;
			item.value = Item.sellPrice(0, 2, 50, 0);
		}

		public override bool DrawHead() {
			return false;
		}
		
	}
}
