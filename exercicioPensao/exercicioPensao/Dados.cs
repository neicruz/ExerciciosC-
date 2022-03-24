namespace exercicioPensao
{
    class Dados
    {
        public string Nome { get; set; }
        public string Email{ get; set; }
       

        public Dados(string nome, string email)
        {
            Nome = nome;
            Email = email;
            
        }

        public override string ToString()
        {
            return Nome
                +", "
                +Email;
        }
    }
}
