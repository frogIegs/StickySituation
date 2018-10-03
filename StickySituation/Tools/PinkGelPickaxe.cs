using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace StickySituation.Tools
{
	public class PinkGelPickaxe : ModItem
	{
		public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("Pink Gel Pickaxe");
		}

		public override void SetDefaults()
		{
			item.damage = 34;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 10;
			item.useAnimation = 20;
			item.pick = 150;
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
            recipe2.AddIngredient(null, "PinkGelBar", 20);
            recipe2.AddIngredient(ItemID.Wood, 5);
            recipe2.AddTile(null, "MythrilGA");
            recipe2.SetResult(this);
            recipe2.AddRecipe();

            ModRecipe recipe3 = new ModRecipe(mod);
            recipe3.AddIngredient(null, "PinkGelBar", 20);
            recipe3.AddIngredient(ItemID.Wood, 5);
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