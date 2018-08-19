using Terraria.ModLoader;
using Terraria.ID;

namespace StickySituation
{
	class StickySituation : Mod
	{
		public StickySituation()
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
