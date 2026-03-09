namespace Encapsulamento;

public class Produto
{
    private string nome;
    private string descricao;
    private decimal preco;
    private int estoque;

    public void CriarProduto(string nome, string descricao, decimal preco, int estoque)
    {
        this.nome = nome;
        this.descricao = descricao;
        this.preco = preco;
        this.estoque = estoque;
    }

    internal bool EstaDisponivel()
    {
        return estoque > 0;
    }

    public void AlterarPrecoComDesconto(decimal desconto)
    {
        preco = preco * (1 - desconto / 100);
    }
}
