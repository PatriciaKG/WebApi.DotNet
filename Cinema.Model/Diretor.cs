namespace Cinema.Model
{
    public class Diretor:Equipe
    {

        public Diretor(string nome, Oscar[] idOscar):base(nome,idOscar)
        {

        }
        
        public string AlgoDiretor {get; private set;}


    }
}