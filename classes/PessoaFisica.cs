namespace POO_heranca.classes
{
    public class PessoaFisica : Pessoa
    {
        public string cpf;
        public string rg;

        public bool ValidarCPF(string documento)
        {
            if(cpf != ""){
                return true;
            }
            return false;
        }
    }
}