using System;
using System.Collections.Generic;
using MongoDB.Driver;
using Cinema.Model;
using Cinema.Data.Config;
using Cinema.Data.Interface;

namespace Cinema.Data.Repository
{
    public class Filme: IFilme
    {
        private readonly IMongoCollection<Model.Filme> _filmes;

        public Filme(IDatabaseConfig DataBaseConfig)
        {
            var client = new MongoClient(DataBaseConfig.ConnectionString);
            var database = client.GetDatabase(DataBaseConfig.DatabaseName);

            _filmes = database.GetCollection<Model.Filme>("TabelaFilme");
        }

        public bool Add(Model.Filme filme)
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

        public void Update(string id, Model.Filme UpdateFilme)
        {
            _filmes.ReplaceOne(oFilme => oFilme.Id == id, UpdateFilme);
        }

        public IEnumerable<Model.Filme> Get()
        {
            return _filmes.Find(filme => true).ToList();
        }

        public Model.Filme Get(string id)
        {
            return _filmes.Find(filme => filme.Id == id).FirstOrDefault();
        }

        public void Delete(string id)
        {
            _filmes.DeleteOne(filme => filme.Id == id);
        }
    }
}