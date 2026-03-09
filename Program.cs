using Encapsulamento;

Produto item1 = new Produto();
item1.nome = "Teclado";
item1.descricao = "Teclado mecanico para jogar";
item1.preco = 80.00m;
item1.estoque = 15;

Console.WriteLine($"Dados do item: {item1.nome} {item1.descricao} {item1.preco} {item1.estoque}");

item1.AlterarPrecoComDesconto(0.2m);





