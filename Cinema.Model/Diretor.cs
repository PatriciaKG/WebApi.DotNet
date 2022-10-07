namespace Cinema.Model
{
    public class Diretor
    {
        public Diretor(string nome, Oscar[] idOscar)
        {
            Id = Guid.NewGuid().ToString();
            Nome = Nome;
            IdOscar = IdOscar;

        }
        public string Id {get; private set;}

        public string Nome {get; private set;}

        public Oscar[] IdOscar {get; private set;}


    }
}