using System;
using System.Collections.Generic;
using Cinema.Model;

namespace Cinema.Data.Interface
{
    public interface IFilme
{
        bool Add(Filme filme);

        bool Update(string id, Filme filme);

        IEnumerable<Filme> Get();
        
        Filme Get(string id);

        void Delete(string id);

}

}
