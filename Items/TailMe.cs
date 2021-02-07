using MonoMod.Cil;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Mono.Cecil.Cil;

namespace SmallVanityProject.Items
{
	[AutoloadEquip(EquipType.Wings)]
	class TailMe : ModItem
	{

		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			DisplayName.SetDefault("His Tail");
			Tooltip.SetDefault("Who has lost his tail?");
			}

		public override void SetDefaults()
		{
			item.accessory = true;
			item.width = 7;
			item.height = 21;
			item.rare = ItemRarityID.Blue;
		}

		public override void UpdateAccessory(Player player, bool hideVisual) {
			player.wingTimeMax = 180;
		}
		
		public override void VerticalWingSpeeds(Player player, ref float ascentWhenFalling, ref float ascentWhenRising, ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend) {
			ascentWhenFalling = 0.85f;
			ascentWhenRising = 0.15f;
			maxCanAscendMultiplier = 1f;
			maxAscentMultiplier = 1f;
			constantAscend = 0.135f;
		}

		public override void HorizontalWingSpeeds(Player player, ref float speed, ref float acceleration) {
			speed = 1f;
			acceleration *= 2.5f;
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
