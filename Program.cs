using Encapsulamento;

Produto item1 = new Produto("Teclado", "mecanico", 80.00m, 12, "imagem");
Console.WriteLine($" {item1.Nome}");
Console.WriteLine($"Detalhes:  {item1.Descricao} {item1.Preco} {item1.Estoque}");

Console.WriteLine($"Imagem: {item1.Imagem}");
item1.Imagem = "Nova imagem";
Console.WriteLine($"Imagem: {item1.Imagem}");



