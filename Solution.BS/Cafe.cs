using Solution.DAL.EF;
using Solution.DO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using data = Solution.DO.Objects;
namespace Solution.BS
{
   public class Cafe : ICRUD<data.Cafe>
    {
        private readonly SolutionDBContext _solutionDBContext = null;

        public Cafe(SolutionDBContext solutionDBContext)
        {
            _solutionDBContext = solutionDBContext;
        }

        public void Delete(data.Cafe t)
        {
            new Solution.DAL.Cafe(_solutionDBContext).Delete(t);
        }

        public IEnumerable<data.Cafe> GetAll()
        {
            return new Solution.DAL.Cafe(_solutionDBContext).GetAll();
        }

        public data.Cafe GetOneById(int id)
        {
            return new Solution.DAL.Cafe(_solutionDBContext).GetOneById(id);
        }

        public void Insert(data.Cafe t)
        {
            t.Id_Cafe = null;

            new Solution.DAL.Cafe(_solutionDBContext).Insert(t);
        }

        public void Update(data.Cafe t)
        {
            new Solution.DAL.Cafe(_solutionDBContext).Update(t);
        }
    }
}
