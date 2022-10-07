using System;
using System.Collections.Generic;
using MongoDB.Driver;
using Cinema.Model;
using Cinema.Data.Config;

namespace Cinema.Data.Repository
{
    public class Filme
    {
        private readonly IMongoCollection<Filme> _filmes;

        public FilmeRepository(IDatabaseConfig DataBaseConfig)
        {
                var client = new MongoClient(DataBaseConfig.ConnectionString);
                var database = client.GetDatabase(DataBaseConfig.DatabaseName);

                _filmes = database.GetCollection<Filme>("Filme");
        }

        public bool Add(Filme filme)
        {              
            try
            {
                _filmes.InsertOne(filme);

                return true;
            }
            catch (System.Exception)
            {                
                return false;
            }            
        }

        public void Update(string id, Filme filme)
        {
            _filmes.ReplaceOne(filme => filme.Id == id, UpdatedFilme);
        }

        public IEnumerable<Filme> Get()
        {
            return _filmes.Find(filme => true).ToList();
        }

        public Filme Get(string id)
        {
            return _filmes.Find(filme => filme.Id == id).FirstOrDefault();
        }

        public void Delete(string id)
        {
            _filmes.DeleteOne(filme => filme.Id == id);
        }
    }
}