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
            
            return categoriaWrapperDAO.executeQuery("select categoria_id as categoriaid,nombre,descripcion,alias from categoria");
        }

        public List<CategoriaWrapper> GetAllCategoriaWrapperNoIniciado()
        {
            DataAccess<CategoriaWrapper> categoriaWrapperDAO = new DataAccess<CategoriaWrapper>();

            //Se tendra que crear por cada uno de los catálogos


            //Codigo para probar
            //List<CategoriaWrapper> newList = new List<CategoriaWrapper>();
            //newList.Add(new CategoriaWrapper() {Nombre="Categoria 1",Descripcion="Cat",CategoriaId=1 });
            //return newList;
            //CODIGO REAL

            return categoriaWrapperDAO.executeQuery("select categoria_id as categoriaid,nombre,descripcion,alias from categoria where !(categoria_id in (select categoria_id from carrera_inicio_categoria)) ");
        }

        public List<ClubWrapper> GetAllClubWrapper()
        {
            DataAccess<ClubWrapper> clubWrapperDAO = new DataAccess<ClubWrapper>();
            return clubWrapperDAO.executeQuery("select club_id as clubid,nombre,descripcion from club");
        }
        public List<CorredorWrapper> GetAllCorredorWrapper()
        {
            DataAccess<CorredorWrapper> corredorWrapperDAO = new DataAccess<CorredorWrapper>();
            return corredorWrapperDAO.executeQuery("select corredor_id as corredorid,numero as numero,concat(corredor.nombre,' ', apellido_paterno,' ',apellido_materno) as nombre,correo,telefono ,club.nombre as club,categoria.nombre as categoria From corredor as corredor inner join categoria as categoria on categoria.categoria_id=corredor.categoria_id inner join club as club on club.club_id=corredor.club_id");
        }
        public List<TiempoWrapper> GetAllTiempoWrapper()
        {
            DataAccess<TiempoWrapper> tiempoWrapperDAO = new DataAccess<TiempoWrapper>();
            return tiempoWrapperDAO.executeQuery("SELECT * FROM corredores_vw");
        }

        public List<CorredorTiempoReporte> GetAllCorredorTiempoReporteWrapper()
        {
            DataAccess<CorredorTiempoReporte> tiempoWrapperDAO = new DataAccess<CorredorTiempoReporte>();
            return tiempoWrapperDAO.executeQuery("SELECT * FROM corredores_tiempo_vw");
        }

        public List<CarreraIniciadaWrapper> GetAllCarreraIniciadaWrapper()
        {
            DataAccess<CarreraIniciadaWrapper> carreraIniciadaWrapperDAO = new DataAccess<CarreraIniciadaWrapper>();
            return carreraIniciadaWrapperDAO.executeQuery("select carrera_inicio_categoria_id as CarreraInicioCategoriaId,alias as categoria,tiempo_inicio_carrera as tiempoiniciocarrera from carrera_inicio_categoria as carincat inner join categoria as categoria on categoria.categoria_id=carincat.categoria_id");
        }

        public int GetBuscaCorredorById(int corredor_id)
        {
            DataAccess<CorredorWrapper> carreraIniciadaWrapperDAO = new DataAccess<CorredorWrapper>();
            List<CorredorWrapper> carreraIniciadaWrapperDAOexecuteQuery = carreraIniciadaWrapperDAO.executeQuery(String.Format("select buscar_corredor({0}) as corredorid", corredor_id));
            return carreraIniciadaWrapperDAOexecuteQuery.FirstOrDefault().CorredorId;
        
        }


        public int GetBuscaCarreraIniciada(int carrera_id)
        {
            DataAccess<CorredorWrapper> carreraIniciadaWrapperDAO = new DataAccess<CorredorWrapper>();
            List<CorredorWrapper> carreraIniciadaWrapperDAOexecuteQuery = carreraIniciadaWrapperDAO.executeQuery(String.Format("select buscar_carrera_iniciada({0}) as corredorid", carrera_id));
            return carreraIniciadaWrapperDAOexecuteQuery.FirstOrDefault().CorredorId;

        }



        public List<CorredorTiempoWrapper> GetReporteGanadores()
        {
            DataAccess<CorredorTiempoWrapper> carreraIniciadaWrapperDAO = new DataAccess<CorredorTiempoWrapper>();
            List<CorredorTiempoWrapper> carreraIniciadaWrapperDAOexecuteQuery = carreraIniciadaWrapperDAO.executeQuery(String.Format("select * from corredores_tiempos_finales_vw"));
            return carreraIniciadaWrapperDAOexecuteQuery;

        }
    }
}
