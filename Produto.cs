namespace Encapsulamento;

public class Produto
{
    private string nome;
    private string descricao;
    private decimal preco;
    private int estoque;

    public bool EstaDisponivel()
    {
        return estoque > 0;
    }

    public void AlterarPrecoComDesconto(decimal desconto)
    {
        preco = preco * (1 - desconto / 100);
    }
}
