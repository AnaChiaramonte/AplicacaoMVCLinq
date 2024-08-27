namespace AplicacaoMVCLinq.Models
{
    public class Cliente
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public DateOnly DataNasc { get; set; }

        public Cliente(int id, string nome, string email, string telefone, DateOnly dataNasc)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Telefone = telefone;
            DataNasc = dataNasc;
        }
    }

}
