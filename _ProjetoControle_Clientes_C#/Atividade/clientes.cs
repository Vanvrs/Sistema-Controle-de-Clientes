//SISTEMA DE CONTROLE DE CLIENTE
//CLASSE CLIENTE

namespace Atividade
{
    class Clientes
    {
        public string nome{get; set;}
        public string endereco {get; set;}
        public float valor {get; protected set;}
        public float valor_imposto {get; protected set;}
        public float total {get; protected set;}
        
        /*MétodoPagar Imposto deve ser definido dentro
        da classe, são as ações que a classe vai 
        realizar. Pode ter vários métodos*/
        //Modificador do método virtual pois o método vai ser reescrito
        public virtual void Pagar_Imposto(float v) //método com argumento do tipo ponto flutuante
        {
            this.valor =v;
            this.valor_imposto = this.valor * 10 / 100;
            this.total = this.valor + this.valor_imposto;
        }
    }
}