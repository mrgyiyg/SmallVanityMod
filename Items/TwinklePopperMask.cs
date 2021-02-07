using Terraria.ModLoader;
using Terraria.ID;

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
		}

		public override bool DrawHead() {
			return false;
		}
		
	}
}
