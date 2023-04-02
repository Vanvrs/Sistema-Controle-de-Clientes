namespace Atividade
{
    class Pessoa_Juridica : Clientes
    {
        public string cnpj {get; set;}
        public string ie {get; set;}
    
     //Polimorismo existe quando tem herança
     public override void Pagar_Imposto(float v) //método override indica que existe esse método e esta sendo reescrito
        {
            this.valor = v;
            this.valor_imposto = this.valor * 20 / 100;
            this.total = this.valor + this.valor_imposto;
        }  
      
    }
}