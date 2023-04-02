//CLASSE PESSOA FÍSICA

namespace Atividade
{
    class Pessoa_Fisica : Clientes //Pessoa fisica herda atributos de clientes. É uma subclasse de Cliente
    {
        public string cpf {get; set;}
        public string rg {get; set;}

    }
}
//abstração pegar um conceito do mundo real e transformar em classes que depois vão virar objetos.