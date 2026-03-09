namespace Encapsulamento;

public class Produto
{
    public string Nome { get;}
    public string Descricao { get; }
    public decimal Preco { get; }
    public int Estoque { get; }
    public string Imagem { get; }

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
        return estoque > 0;
    }

    public void AlterarPrecoComDesconto(decimal desconto)
    {
        preco = preco * (1 - desconto / 100);
    }


    // Acesso a Dados GET
    public string GetNome()
    {
        return nome;
    }

    public string GetImagem()
    {
        return imagem;
    }

    // Alteracao de Dados SET
    public void SetImagem(string imagem)
    {
        if (imagem.Length > 0) // verificando antes de alterar
        {
            this.imagem = imagem; // alterando atributo
        }
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
