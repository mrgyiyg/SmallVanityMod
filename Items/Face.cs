using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Microsoft.Xna.Framework;

namespace SmallVanityProject.Items
{
	[AutoloadEquip(EquipType.Head)]
	public class Face : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			DisplayName.SetDefault("Face");
			Tooltip.SetDefault("I hope you are enjoying my completely normal face and head");
			}
			
		public override void SetDefaults() {
			item.width = 30;
			item.height = 26;
			item.rare = ItemRarityID.Red;
			item.vanity = true;
			item.value = Item.sellPrice(0, 1, 50, 0);
		}

		public override bool DrawHead() {
			return false;
		}
		
		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LifeCrystal, 1);
			recipe.AddIngredient(ItemID.AngelStatue, 1);
			recipe.AddIngredient(ItemID.UnholyWater, 1);		
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
