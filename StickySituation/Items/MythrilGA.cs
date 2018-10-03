using Terraria.ID;
using Terraria.ModLoader;

namespace StickySituation.Items
{
	public class MythrilGA : ModItem
	{
		public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("Mythril Gel Anvil");
			Tooltip.SetDefault("Functions as a mythril anvil.");
		}

		public override void SetDefaults()
		{
			item.width = 28;
			item.height = 14;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
            item.rare = 3;
			item.consumable = true;
			item.value = 15000;
			item.createTile = mod.TileType("MythrilGA");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe1 = new ModRecipe(mod);
			recipe1.AddIngredient(ItemID.MythrilAnvil);
			recipe1.AddIngredient(null, "GelBar", 10);
            recipe1.AddTile(null, "GelAnvil");
			recipe1.SetResult(this);
			recipe1.AddRecipe();

            ModRecipe recipe3 = new ModRecipe(mod);
            recipe3.AddIngredient(null, "MythrilGA");
            recipe3.SetResult(null, "OrichalcumGA");
            recipe3.AddRecipe();

            ModRecipe recipe4 = new ModRecipe(mod);
            recipe4.AddIngredient(null, "OrichalcumGA");
            recipe4.SetResult(null, "MythrilGA");
            recipe4.AddRecipe();
		}
	}
}