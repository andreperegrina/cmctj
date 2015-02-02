using Common.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMCTJ.BusinessLogic.Manager
{
    //DataAccess<TEntity> : IDataAccess<TEntity>
    public class GeneralManager<TEntity> where TEntity : class
    {

        protected readonly DataAccess<TEntity> entityDAO = new DataAccess<TEntity>();

        public List<TEntity> GetAll()
        {
            return entityDAO.FindAll();
        }

        public int Save(TEntity nuevaEntity)
        {
            return entityDAO.Save(nuevaEntity);
        }

        public int Remove(TEntity EntityRemove)
        {

            return entityDAO.Delete(EntityRemove);
        }

        public int Update(TEntity editEntity)
        {
            return entityDAO.Update(editEntity);
        }


        

    }
}
