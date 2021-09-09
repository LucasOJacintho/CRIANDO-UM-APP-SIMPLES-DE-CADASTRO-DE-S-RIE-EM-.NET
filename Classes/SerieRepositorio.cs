using System;
using System.Collections.Generic;
using CRIANDO_UM_APP_SIMPLES_DE_CADASTRO_DE_SÉRIE_EM_.NET.Interfaces;

namespace CRIANDO_UM_APP_SIMPLES_DE_CADASTRO_DE_SÉRIE_EM_.NET.Classes
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
       private List<Serie> listaSerie = new List<Serie>();
       public void Atualiza(int id, Serie objeto)
       {
           listaSerie[id] = objeto;
           //throw new NotimplementedException();
       }
       public void Exclui(int id, Serie id)
       {
           listaSerie[id].Exluir();
           //throw new NotimplementedException();
       } 
       public void Insere(int id, Serie entidade)
       {
           ListaSerie.Add(objeto);
           //throw new NotimplementedException();
       } 
       public List<Serie> Lista()
       {
           return listaSerie;
           //throw new NotimplementedException();
       } 
       public int ProximoId()
       {
           return listaSerie.Count;
           //throw new NotimplementedException();
       }
       public int RetornaPorId(int id)
       {
           retunr listaSerie[id];
           //throw new NotimplementedException();
       } 

    }
}