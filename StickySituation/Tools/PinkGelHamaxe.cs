using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace StickySituation.Tools
{
	public class PinkGelHamaxe : ModItem
	{
		public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("Pink Gel Hamaxe");
		}

		public override void SetDefaults()
		{
			item.damage = 26;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 15;
			item.useAnimation = 35;
			item.axe = 25;			//How much axe power the weapon has, note that the axe power displayed in-game is this value multiplied by 5
			item.hammer = 165;		//How much hammer power the weapon has
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
            ModRecipe recipe2 = new ModRecipe(mod);
            recipe2.AddIngredient(null, "PinkGelBar", 15);
            recipe2.AddIngredient(ItemID.Wood, 4);
            recipe2.AddTile(null, "MythrilGA");
            recipe2.SetResult(this);
            recipe2.AddRecipe();

            ModRecipe recipe3 = new ModRecipe(mod);
            recipe3.AddIngredient(null, "PinkGelBar", 15);
            recipe3.AddIngredient(ItemID.Wood, 4);
            recipe3.AddTile(null, "OrichalcumGA");
            recipe3.SetResult(this);
            recipe3.AddRecipe();
        }
        
	}
}
