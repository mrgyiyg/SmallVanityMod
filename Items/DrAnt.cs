using Terraria.ModLoader;
using Terraria.ID;

namespace SmallVanityProject.Items
{
	[AutoloadEquip(EquipType.Head)]
	public class DrAnt : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			DisplayName.SetDefault("Dr. Ant's Head");
			Tooltip.SetDefault("I'm so glad you could make it to my tea party");
			}
			
		public override void SetDefaults() {
			item.width = 40;
			item.height = 30;
			item.rare = ItemRarityID.Blue;
			item.vanity = true;
		}

		public override bool DrawHead() {
			return false;
		}
		
		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LesserManaPotion, 3);			
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
