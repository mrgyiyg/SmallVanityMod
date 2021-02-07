using Terraria.ModLoader;
using Terraria.ID;

namespace SmallVanityProject.Items
{
	[AutoloadEquip(EquipType.Head)]
	public class PerryFace : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			DisplayName.SetDefault("Perry's Face");
			Tooltip.SetDefault("Perry Perihelion (Perry Perihelion)");
			}
			
		public override void SetDefaults() {
			item.width = 36;
			item.height = 26;
			item.rare = ItemRarityID.Yellow;
			item.vanity = true;
		}

		public override bool DrawHead() {
			return false;
		}
		
		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Shrimp, 1);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
