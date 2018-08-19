using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace StickySituation.Projectiles
{
    public class GelCoatedArrowP : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Gel Coated Arrow");
        }
        public override void SetDefaults()
        {
            projectile.width = 8;  //Set the hitbox width
            projectile.height = 8;  //Set the hitbox height
            projectile.aiStyle = 1; //How the projectile works
            projectile.friendly = true;  //Tells the game whether it is friendly to players/friendly npcs or not
            projectile.hostile = false; //Tells the game whether it is hostile to players or not
            projectile.tileCollide = true; //Tells the game whether or not it can collide with a tile
            projectile.ignoreWater = true; //Tells the game whether or not projectile will be affected by water
            projectile.ranged = true;   //Tells the game whether it is a ranged projectile or not
            projectile.penetrate = 2; //Tells the game how many enemies it can hit before being destroyed
            projectile.timeLeft = 400; //The amount of time the projectile is alive for
            aiType = 1; // this is the projectile ai style . 1 is for arrows style
        }

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit) //When you hit an NPC
        {

            target.AddBuff(BuffID.Slow, 240);    //this adds a buff to the npc hit. 210 it the time of the buff

        }
        //After the projectile is dead
        public override bool OnTileCollide(Vector2 oldVelocity)
        {                                                           // sound that the projectile make when hiting the terrain
            {
                projectile.Kill();

                Main.PlaySound(0, (int)projectile.position.X, (int)projectile.position.Y, 0);
            }
            return false;
        }


    }
}