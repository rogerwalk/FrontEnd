using Solution.DAL.EF;
using Solution.DO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using data = Solution.DO.Objects;
namespace Solution.BS
{
   public class Marcas : ICRUD<data.Marcas>
    {
        private readonly SolutionDBContext _solutionDBContext = null;

        public Marcas(SolutionDBContext solutionDBContext)
        {
            _solutionDBContext = solutionDBContext;
        }

        public void Delete(data.Marcas t)
        {
            new Solution.DAL.Marcas(_solutionDBContext).Delete(t);
        }

        public IEnumerable<data.Marcas> GetAll()
        {
            return new Solution.DAL.Marcas(_solutionDBContext).GetAll();
        }

        public data.Marcas GetOneById(int id)
        {
            return new Solution.DAL.Marcas(_solutionDBContext).GetOneById(id);
        }

        public void Insert(data.Marcas t)
        {
            t.Id_Marca = null;

            new Solution.DAL.Marcas(_solutionDBContext).Insert(t);
        }

        public void Update(data.Marcas t)
        {
            new Solution.DAL.Marcas(_solutionDBContext).Update(t);
        }
    }
}
