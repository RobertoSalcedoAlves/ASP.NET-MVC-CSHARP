using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinaWeb.Repositorios.Comum
{
    public interface IRepositorioGenerico<TEntidade, TChave>
        where TEntidade : class
    {
        void Inserir(TEntidade entidade);
        void Alterar(TEntidade entidade);
        void Excluir(TEntidade entidade);
        void ExcluirPorId(TChave id);
        List<TEntidade> Selecionar();
        TEntidade SelecionarPorId(TChave id);
    }
}
