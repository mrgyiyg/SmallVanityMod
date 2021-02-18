using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace SmallVanityProject.Tiles
{
	class AntFarm : ModTile
	{
		public override void SetDefaults() {
			Main.tileFrameImportant[Type] = true;
			Main.tileLighted[Type] = true;
			Main.tileLavaDeath[Type] = true;

			TileObjectData.newTile.CopyFrom(TileObjectData.StyleSmallCage);
			TileObjectData.addTile(Type);

			animationFrameHeight = 36;

			ModTranslation name = CreateMapEntryName();
			name.SetDefault("Ant Farm");
			AddMapEntry(new Color(122, 217, 232), name);
		}

		public override void KillMultiTile(int i, int j, int frameX, int frameY) {
			Item.NewItem(i * 16, j * 16, 48, 32, ModContent.ItemType<AntFarmItem>());
		}

		public override void AnimateIndividualTile(int type, int i, int j, ref int frameXOffset, ref int frameYOffset) {
			Tile tile = Main.tile[i, j];
			Main.critterCage = true;
			int left = i - tile.frameX / 18;
			int top = j - tile.frameY / 18;
			int offset = left / 3 * (top / 3);
			offset %= Main.cageFrames;
			frameYOffset = Main.wormCageFrame[offset] * animationFrameHeight;
		}
	}

	internal class AntFarmItem : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Ant Farm");
		}

		public override void SetDefaults() {
			item.CloneDefaults(ItemID.WormCage);
			item.createTile = ModContent.TileType<AntFarm>();
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Terrarium);
			recipe.AddIngredient(ModContent.ItemType<NPCs.AntItem>());
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
