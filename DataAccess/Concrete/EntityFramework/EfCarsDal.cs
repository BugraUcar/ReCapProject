using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarsDal : ICarsDal
    {
        public void Add(Cars entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Cars entity)
        {
            throw new NotImplementedException();
        }

        public Cars Get(Expression<Func<Cars, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Cars> GetAll(Expression<Func<Cars, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Cars entity)
        {
            throw new NotImplementedException();
        }
    }
}
