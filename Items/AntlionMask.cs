using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Microsoft.Xna.Framework;

namespace SmallVanityProject.Items
{
	[AutoloadEquip(EquipType.Head)]
	public class AntlionMask : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			DisplayName.SetDefault("Antlion Mask");
			}
			
		public override void SetDefaults() {
			item.width = 28;
			item.height = 26;
			item.rare = ItemRarityID.Blue;
			item.vanity = true;
			item.value = Item.sellPrice(0, 1, 50, 0);
		}

		public override bool DrawHead() {
			return false;
		}
		
		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.AntlionMandible, 2);			
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
