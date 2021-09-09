using Sustem.Collections.Generic;

namespace CRIANDO_UM_APP_SIMPLES_DE_CADASTRO_DE_SÉRIE_EM_.NET.Interfaces
{
    public interface IRepositorio
    {
         List<T> Lista();
         T RetornaPorId (int id);

         void Insere (T entidade);

         void Exclui(int id);

         void Atualiza (int id, T endidade);

         int ProximoId(); 
    }
}