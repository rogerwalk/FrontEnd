using Solution.DAL.EF;
using Solution.DAL.Repository;
using Solution.DO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using data = Solution.DO.Objects;
namespace Solution.DAL
{
  public   class Cafe : ICRUD<data.Cafe>
    {

        private readonly Repository<data.Cafe> _repository = null;



        public Cafe(SolutionDBContext solutionDBContext)
        {
            _repository = new Repository<data.Cafe>(solutionDBContext);
        }

        public void Delete(data.Cafe t)
        {
            _repository.Delete(t);
            _repository.Commit();
        }

        public IEnumerable<data.Cafe> GetAll()
        {
            return _repository.GetAll();
        }

        public data.Cafe GetOneById(int id)
        {
            return _repository.GetOneById(id);
        }

        public void Insert(data.Cafe t)
        {
            _repository.Insert(t);
            _repository.Commit();
        }

        public void Update(data.Cafe t)
        {
            _repository.Update(t);
            _repository.Commit();
        }

    }
}
