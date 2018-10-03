using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace StickySituation.Tools
{
	public class GelPickaxe : ModItem
	{
		public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("Gel Pickaxe");
			Tooltip.SetDefault("Caution: May stick on impact.");
		}

		public override void SetDefaults()
		{
			item.damage = 10;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 10;
			item.useAnimation = 20;
			item.pick = 40;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "GelBar", 9);
			recipe.AddTile(null, "GelAnvil");
			recipe.SetResult(this);
			recipe.AddRecipe();

            ModRecipe recipe2 = new ModRecipe(mod);
            recipe2.AddIngredient(null, "GelBar", 9);
            recipe2.AddTile(null, "MythrilGA");
            recipe2.SetResult(this);
            recipe2.AddRecipe();

            ModRecipe recipe3 = new ModRecipe(mod);
            recipe3.AddIngredient(null, "GelBar", 9);
            recipe3.AddTile(null, "OrichalcumGA");
            recipe3.SetResult(this);
            recipe3.AddRecipe();
		}

		public override void MeleeEffects(Player player, Rectangle hitbox)
		{
			if (Main.rand.Next(10) == 0)
			{
				int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, mod.DustType("Sparkle"));
			}
		}
	}
}