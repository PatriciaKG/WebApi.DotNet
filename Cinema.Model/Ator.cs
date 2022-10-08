namespace Cinema.Model
{

//Exemplo de OOP - Abstração
    public class Ator:Equipe
    {
        public Ator(string nome, Oscar[] idOscar):base(nome,idOscar)
        {

        }
        public string AlgoAtor {get; private set;}    
    }
}