using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaMod.Items
{
	public class SuperAnvil : ModItem
	{
		public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("Super Anvil");
			Tooltip.SetDefault("Functions as almost all vanilla crafting stations."
                + "\nDoes not include ancient manipulator." +
                "\nDoes include demon/crimson altars." +
                "\nExpert mode only.");
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
            item.expert = true;
            item.rare = -12;
            item.expertOnly = true;
			item.consumable = true;
			item.value = 0;
			item.createTile = mod.TileType("SuperAnvil");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe1 = new ModRecipe(mod);
			recipe1.AddIngredient(ItemID.MythrilAnvil); //OrichalcumAnvil
			recipe1.AddIngredient(ItemID.WorkBench);
            recipe1.AddIngredient(ItemID.AdamantiteForge); //TitaniumForge
            recipe1.AddIngredient(ItemID.Solidifier);
            recipe1.AddIngredient(ItemID.IceMachine);
            recipe1.AddIngredient(ItemID.AlchemyTable);
            recipe1.AddIngredient(ItemID.Sawmill);
            recipe1.AddIngredient(ItemID.Loom);
            recipe1.AddIngredient(ItemID.LivingLoom);
            recipe1.AddIngredient(ItemID.CookingPot); //Cauldron
            recipe1.AddIngredient(ItemID.TinkerersWorkshop);
            recipe1.AddIngredient(ItemID.ImbuingStation);
            recipe1.AddIngredient(ItemID.CrystalBall);
            recipe1.AddIngredient(ItemID.Autohammer);
            recipe1.AddTile(TileID.Furnaces);
			recipe1.SetResult(this);
			recipe1.AddRecipe();

            
		}
	}
}