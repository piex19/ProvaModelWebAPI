namespace PatrimonioSenaiTaguatinga.Entities
{
    public class Registro
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int IdNivel { get; set; }

        public Registro(string nome, string sobrenome, string login, string password, int idNivel)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Login = login;
            Password = password;
            IdNivel = idNivel;
           
        }

        public Nivel Nivel { get; set; } = null!;
    }
}
