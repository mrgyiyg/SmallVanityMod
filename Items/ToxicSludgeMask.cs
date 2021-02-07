using Terraria.ModLoader;
using Terraria.ID;

namespace SmallVanityProject.Items
{
	[AutoloadEquip(EquipType.Head)]
	public class ToxicSludgeMask : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			DisplayName.SetDefault("Toxic Sludge Mask");
			}
			
		public override void SetDefaults() {
			item.width = 36;
			item.height = 28;
			item.rare = ItemRarityID.Blue;
			item.vanity = true;
		}

		public override bool DrawHead() {
			return false;
		}
		
	}
}
