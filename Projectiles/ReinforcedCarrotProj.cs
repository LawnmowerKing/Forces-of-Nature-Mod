using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Audio;

namespace Thinf.Projectiles
{
	public class ReinforcedCarrotProj : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Reinforced Carrot");     //The English name of the projectile
		}

		public override void SetDefaults()
		{
			projectile.width = 32;               //The width of projectile hitbox
			projectile.height = 22;              //The height of projectile hitbox
			projectile.friendly = true;         //Can the projectile deal damage to enemies?
			projectile.hostile = false;         //Can the projectile deal damage to the player?
			projectile.magic = false;
			projectile.minion = false;
			projectile.melee = false;
			projectile.thrown = false;
			projectile.ranged = false;
			projectile.penetrate = 1;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
			projectile.timeLeft = 1200;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
			projectile.ignoreWater = false;          //Does the projectile's speed be influenced by water?
			projectile.tileCollide = true;          //Can the projectile collide with tiles?
			aiType = ProjectileID.Bullet;           //Act exactly like default Bullet
		}

		public override void AI()
		{
			projectile.rotation = projectile.velocity.ToRotation();
		}

		public override void Kill(int timeLeft)
		{
			// This code and the similar code above in OnTileCollide spawn dust from the tiles collided with. SoundID.Item10 is the bounce sound you hear.
			Collision.HitTiles(projectile.position + projectile.velocity, projectile.velocity, projectile.width, projectile.height);
			Main.PlaySound(SoundID.NPCDeath1, projectile.position);
		}
	}
}
