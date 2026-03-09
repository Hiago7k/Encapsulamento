namespace Encapsulamento;

public class Produto
{
    private string imagem;
    public string Nome { get;}
    public string Descricao { get; }
    public decimal Preco { get; private set; }
    public int Estoque { get; }

    public Produto(string nome, string descricao, decimal preco, int estoque, string imagem)
    { 
        this.Nome = nome;
        this.Descricao = descricao;
        this.Preco = preco;
        this.Estoque = estoque;
        this.Imagem = imagem;
    }


    internal bool EstaDisponivel()
    {
        return Estoque > 0;
    }

    public void AlterarPrecoComDesconto(decimal desconto)
    {
        Preco = Preco * (1 - desconto / 100);
    }
  
    public string Imagem
    {
        get 
        {
            return imagem;
        }
        set 
        {
            if (value.Length > 0)
            {
                this.imagem = value;
            }
        }
    }
}
