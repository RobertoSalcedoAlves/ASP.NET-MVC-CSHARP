using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinaWeb.Musicas.AcessoDados.Entity.Context;
using TreinaWeb.Musicas.Dominio;
using TreinaWeb.Repositorios.Comum.Entity;
using System.Data.Entity;

namespace TreinaWeb.Musicas.Repositorios.Entity
{
    public class MusicasRepositorio : RepositorioGenericoEntity<Musica, long>
    {
        public MusicasRepositorio(MusicasDbContext contexto) : base(contexto) { }

        public override List<Musica> Selecionar()
        {
            return _contexto.Set<Musica>().Include(p => p.Album).ToList();
        }

        public override Musica SelecionarPorId(long id)
        {
            return _contexto.Set<Musica>().Include(p => p.Album).SingleOrDefault(mus => mus.Id == id);
        }
    }
}
