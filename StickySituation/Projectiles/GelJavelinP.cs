using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace StickySituation.Projectiles
{
    public class GelJavelinP : ModProjectile
    {
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Gel Javelin");
			
		}
        public override void SetDefaults()
        {
            //projectile.name = "Gel Boomerang";  //this is the projectile name
            projectile.width = 44;
            projectile.height = 20;
            projectile.friendly = true;
            projectile.aiStyle = 1;
            projectile.thrown = true;
            projectile.penetrate = 2;      //this is how many enemy this projectile penetrate before desapear 
            projectile.extraUpdates = 1;
            aiType = ProjectileID.JavelinHostile;
        }

        public override void AI()
        {
            projectile.ai[0] += 1f;
            if (projectile.ai[0] >= 5000f)       //how much time the projectile can travel before landing
            {
                projectile.velocity.Y = projectile.velocity.Y + 0.1f;    // projectile fall velocity
                projectile.velocity.X = projectile.velocity.X * 3.25f;    // projectile velocity
            }
        }
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
