using Terraria.ModLoader;
using Terraria.ID;

namespace TerrariaMod
{
	class TerrariaMod : Mod
	{
		public TerrariaMod()
		{
            Properties = new ModProperties()
            {
                Autoload = true,
                AutoloadGores = true,
                AutoloadSounds = true
            };
		}
	}
}
