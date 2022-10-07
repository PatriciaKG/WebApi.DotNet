namespace Cinema.Model
{
    public class CategoriaOscar
    {
        public CategoriaOscar(string descricao)
        {
            Id = Guid.NewGuid().ToString();
            Descricao = descricao;
            DataCadastro = DateTime.Now;
        }

        public string Id {get; private set;}

        public string Descricao {get; private set;}

        public DateTime DataCadastro {get; private set;}
    }
}