namespace Cinema.Model
{
    public class Filme
    {
        
            public Filme(string nome, string sinopse, int anoEstreia, Diretor[] idDiretor, Ator[] idAtor, bool pretoBranco, CategoriaFilme categoria)
            {

                Id = Guid.NewGuid().ToString();
                Nome = nome;
                Sinopse = sinopse;
                AnoEstreia = anoEstreia;
                IdDiretor = idDiretor;
                IdAtor = idAtor;
                PretoBranco = pretoBranco;
                Categoria = categoria;
                DataCadastro = DateTime.Now;
                DataAlteracao = DateTime.Now;

            }

            public string Id {get; private set;}

            public string Nome {get; private set;}

            public string Sinopse {get; private set;}

            public int AnoEstreia {get; private set;}

            public bool PretoBranco {get; private set;}

            public Diretor[] IdDiretor {get; private set;}

            public Ator[] IdAtor {get; private set;}

            public CategoriaFilme Categoria {get; private set;}

            public DateTime DataCadastro {get; private set;}

            public DateTime DataAlteracao {get; private set;}

            public void AlteraFilme(string nome, string sinopse, int anoEstreia, Diretor[] idDiretor, Ator[] idAtor, bool pretoBranco, CategoriaFilme categoria)
            {

                Id = Guid.NewGuid().ToString();
                Nome = nome;
                Sinopse = sinopse;
                AnoEstreia = anoEstreia;
                IdDiretor = idDiretor;
                IdAtor = idAtor;
                PretoBranco = pretoBranco;
                Categoria = categoria;
                DataAlteracao = DateTime.Now;

            }

    }
}