﻿using Solution.DAL.EF;
using Solution.DAL.Repository;
using Solution.DO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using data = Solution.DO.Objects;
namespace Solution.DAL
{
    public class Productor : ICRUD<data.Productor>
    {


        private readonly Repository<data.Productor> _repository = null;
        


        public Productor(SolutionDBContext solutionDBContext)
        {
            _repository = new Repository<data.Productor>(solutionDBContext);
        }

        public void Delete(data.Productor t)
        {
            _repository.Delete(t);
            _repository.Commit();
        }

        public IEnumerable<data.Productor> GetAll()
        {
            return _repository.GetAll();
        }

        public data.Productor GetOneById(int id)
        {
            return _repository.GetOneById(id);
        }

        public void Insert(data.Productor t)
        {
            _repository.Insert(t);
            _repository.Commit();
        }

        public void Update(data.Productor t)
        {
            _repository.Update(t);
            _repository.Commit();
        }
    }
}
