using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PokemonJuego.Startup))]
namespace PokemonJuego
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
