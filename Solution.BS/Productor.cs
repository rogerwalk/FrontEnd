using Solution.DAL.EF;
using Solution.DO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using data = Solution.DO.Objects;
namespace Solution.BS
{
   public class Productor : ICRUD<data.Productor>
    {
        private readonly SolutionDBContext _solutionDBContext = null;

        public Productor(SolutionDBContext solutionDBContext)
        {
            _solutionDBContext = solutionDBContext;
        }

        public void Delete(data.Productor t)
        {
            new Solution.DAL.Productor(_solutionDBContext).Delete(t);
        }

        public IEnumerable<data.Productor> GetAll()
        {
            return new Solution.DAL.Productor(_solutionDBContext).GetAll();
        }

        public data.Productor GetOneById(int id)
        {
            return new Solution.DAL.Productor(_solutionDBContext).GetOneById(id);
        }

        public void Insert(data.Productor t)
        {
            t.Id_Productor = null;

            new Solution.DAL.Productor(_solutionDBContext).Insert(t);
        }

        public void Update(data.Productor t)
        {

            new Solution.DAL.Productor(_solutionDBContext).Update(t);
        }
    }
}
