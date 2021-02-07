using Terraria.ModLoader;
using Terraria.ID;

namespace SmallVanityProject.Items
{
	[AutoloadEquip(EquipType.Head)]
	public class HeadMe : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			DisplayName.SetDefault("His Visage");
			}
			
		public override void SetDefaults() {
			item.width = 32;
			item.height = 24;
			item.rare = ItemRarityID.Blue;
			item.vanity = true;
		}

		public override bool DrawHead() {
			return false;
		}
		
		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LunarOre, 3);			
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
