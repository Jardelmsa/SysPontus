using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CAMADA.DALL.Models
{
  public  class Funcionarios
    {
        public int Id { get; set; }
        public string CPF_CNPJ { get; set; }
        public string NomeCompleto { get; set; }
        public int Matricula { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public string Sexo { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Cargo { get; set; }
    }
}
