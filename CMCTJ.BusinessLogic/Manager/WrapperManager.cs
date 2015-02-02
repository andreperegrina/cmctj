using CMCTJ.BusinessLogic.Wrapper;
using Common.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMCTJ.BusinessLogic.Manager
{
    public class WrapperManager
    {
        public List<CategoriaWrapper> GetAllCategoriaWrapper()
        {
            DataAccess<CategoriaWrapper> categoriaWrapperDAO = new DataAccess<CategoriaWrapper>();

            //Se tendra que crear por cada uno de los catálogos


            //Codigo para probar
            //List<CategoriaWrapper> newList = new List<CategoriaWrapper>();
            //newList.Add(new CategoriaWrapper() {Nombre="Categoria 1",Descripcion="Cat",CategoriaId=1 });
            //return newList;
            //CODIGO REAL
            return categoriaWrapperDAO.executeQuery("select * from categoria");
        }

        public List<ClubWrapper> GetAllClubWrapper()
        {
            DataAccess<ClubWrapper> clubWrapperDAO = new DataAccess<ClubWrapper>();
            return clubWrapperDAO.executeQuery("select * from categoria");
        }
    }
}
