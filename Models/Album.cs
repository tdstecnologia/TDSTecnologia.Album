using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TDSTecnologia.FaceAlbum.Web.Models
{
    public class Album
    {
        public int AlbumId { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string Capa { get; set; }
        public DateTime DataInicio { get; set; }
    }
}