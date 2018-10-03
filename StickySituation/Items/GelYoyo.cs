using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;                     
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace StickySituation.Items
{
    public class GelYoyo : ModItem   
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Gel YoYo");
            Tooltip.SetDefault("Sticky and tasty!");
        }

        public override void SetDefaults()
        {
            item.damage = 19;
            item.melee = true;  
            item.useTime = 22; 
            item.useAnimation = 22;   
            item.useStyle = 5;
            item.channel = true;
            item.knockBack = 2f;
            item.value = Item.buyPrice(0, 0, 50, 00); 
            item.rare = 1;
            item.autoReuse = false;  
            item.shoot = mod.ProjectileType("GelYoyoP"); 
            item.noUseGraphic = true; 
            item.noMelee = true;
            item.UseSound = SoundID.Item1; 

        }
        
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "GelBar", 5);
            recipe.AddIngredient(ItemID.Cobweb, 20);
            recipe.AddTile(null, "GelAnvil");
            recipe.SetResult(this);
            recipe.AddRecipe();

            ModRecipe recipe2 = new ModRecipe(mod);
            recipe2.AddIngredient(null, "GelBar", 5);
            recipe2.AddIngredient(ItemID.Cobweb, 20);
            recipe2.AddTile(null, "MythrilGA");
            recipe2.SetResult(this);
            recipe2.AddRecipe();

            ModRecipe recipe3 = new ModRecipe(mod);
            recipe3.AddIngredient(null, "GelBar", 5);
            recipe3.AddIngredient(ItemID.Cobweb, 20);
            recipe3.AddTile(null, "OrichalcumGA");
            recipe3.SetResult(this);
            recipe3.AddRecipe();
        }
    }
}