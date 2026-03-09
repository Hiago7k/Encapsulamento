using Encapsulamento;

Produto item1 = new Produto("Teclado", "mecanico", 80.00m, 12, "imagem");
//Console.WriteLine($" {item1.ObterNome()}");
//Console.WriteLine($"Detalhes: {item1.nome} {item1.descricao} {item1.preco] {item1.estoque}");

Console.WriteLine($"Imagem: {item1.Imagem}");
item1.SetImagem("Nova imagem");
Console.WriteLine($"Imagem: {item1.Imagem}");



