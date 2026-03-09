namespace Encapsulamento;

public class Produto
{
    private string nome;
    private string descricao;
    private decimal preco;
    private int estoque;
    private string imagem;

    public Produto(string nome, string descricao, decimal preco, int estoque, string imagem)
    { 
        this.nome = nome;
        this.descricao = descricao;
        this.preco = preco;
        this.estoque = estoque;
        this.imagem = imagem;
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
}
