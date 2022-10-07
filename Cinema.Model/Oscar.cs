namespace Cinema.Model
{
    public class Oscar 
    {
        public Oscar(CategoriaOscar categoria, int ano)
        {
            Id = Guid.NewGuid().ToString();
            Categoria = categoria;
            ano = Ano;
        }
        public string Id {get; private set;}

        public CategoriaOscar Categoria {get; private set;}

        public int Ano {get; private set;}
    }
}