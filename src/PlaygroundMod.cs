using Vintagestory.API.Client;
using Vintagestory.API.Common;
using Vintagestory.API.Server;

[assembly: ModInfo("Playground",
    Description = "Playground mod",
    Website = "https://github.com/MrNovado/vintage-story-playground",
    Authors = new[] { "mrnovado" },
    Version = "1.12.5"),]

namespace Playground
{
    public class PlaygroundMod : ModSystem
    {
        public override void Start(ICoreAPI api)
        {

        }

        public override void StartClientSide(ICoreClientAPI api)
        {

        }

        public override void StartServerSide(ICoreServerAPI api)
        {

        }
    }
}
