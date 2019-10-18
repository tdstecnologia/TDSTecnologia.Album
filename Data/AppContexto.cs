using Microsoft.EntityFrameworkCore;

namespace TDSTecnologia.FaceAlbum.Web.Data
{
    public class AppContexto : DbContext
    {
        public AppContexto(DbContextOptions<AppContexto> opcoes) : base(opcoes)
        {
        }
    }
}
