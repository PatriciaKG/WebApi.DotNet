namespace Cinema.Model
{
    public abstract class Equipe
    {
        public Equipe(string nome, Oscar[] idOscar)
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