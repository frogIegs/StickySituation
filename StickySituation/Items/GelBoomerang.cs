using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace StickySituation.Items
{
    public class GelBoomerang : ModItem
    {
         public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Gel Boomerang");
			Tooltip.SetDefault("Sticky and tasty!");
		}
        public override void SetDefaults()
        {
            
            item.damage = 22;            
            item.melee = true;
            item.width = 18;
            item.height = 32;
            
            item.useTime = 50;
            item.useAnimation = 15;
            item.noUseGraphic = false;
            item.useStyle = 1;
            item.knockBack = 3;
            item.value = 75;
            item.rare = 1;
            item.shootSpeed = 5.5f;
            item.shoot = mod.ProjectileType ("GelBoomerangP");
            item.UseSound = SoundID.Item1;
            item.autoReuse = false;
        }
        public override bool CanUseItem(Player player)       //this make that you can shoot only 1 boomerang at once
        {
            for (int i = 0; i < 1000; ++i)
            {
                if (Main.projectile[i].active && Main.projectile[i].owner == Main.myPlayer && Main.projectile[i].type == item.shoot)
                {
                    return false;
                }
            }
            return true;
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
    }
}