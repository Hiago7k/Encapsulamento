using Encapsulamento;

Produto item1 = new Produto("Teclado", "mecanico", 80.00m, 12);
Console.WriteLine($" {item1.ObterNome()}");
//Console.WriteLine($"Detalhes: {item1.nome} {item1.descricao} {item1.preco] {item1.estoque}");


item1.AlterarPrecoComDesconto(0.2m);
