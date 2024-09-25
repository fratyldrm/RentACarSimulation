using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.ConsoleUI.Repository
{
    internal interface IRepository<TEntity>
    {
        void Add(TEntity data);
        void Update(TEntity data);
        void Delete(TEntity data);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
    }
}
