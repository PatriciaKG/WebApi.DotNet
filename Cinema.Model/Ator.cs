namespace Cinema.Model
{
    public class Ator
    {
        public Ator(string nome, Oscar[] idOscar)
        {
            Id = Guid.NewGuid().ToString();
            Nome = nome;
            IdOscar = idOscar;

        }
        public string Id {get; private set;}

        public string Nome {get; private set;}

        public Oscar[] IdOscar {get; private set;}


    }
}