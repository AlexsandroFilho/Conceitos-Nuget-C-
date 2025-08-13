using nuget.Models;
using Newtonsoft.Json;

/* DateTime dataAtual = DateTime.Now;
List<Venda> vendas = new List<Venda>();

//Instancia da classe no objeto "venda"
Venda venda1 = new Venda(1, "madeira", 12.00M,  dataAtual);
Venda venda2 = new Venda(2, "chapa de ferro", 20.00M, dataAtual);

//Adicionando itens a lista
vendas.Add(venda1);
vendas.Add(venda2);

//Conversão do objeto para o formato JSON, com a saída formatada
string serializado = JsonConvert.SerializeObject(vendas, Formatting.Indented);

//Criando arquivo JSON a partir da referencia do objeto convertido
File.WriteAllText("Arquivos/vendas.json", serializado);

Console.WriteLine(serializado); */

//importanto um arquivo json para objeto

/* string conteudoArquivoVendas = File.ReadAllText("Arquivos/vendas.json");

List<Venda> vendas = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivoVendas);

foreach (Venda venda in vendas)
{
    Console.WriteLine($"ID: {venda.ID}, Produto {venda.Nome}, Preço {venda.Preco}," +
                        $" Data de compra: {venda.DataAtual}" +
                        $"{(venda.Desconto.HasValue? $", Desconto de {venda.Desconto}": "")}");
} */


//Tipo anonimo 

var tipoAnonimo = new { nome = "Alex", contaCorrente = 1312.54M };

Console.WriteLine($"Nome: {tipoAnonimo.nome}");
Console.WriteLine($"Saldo: {tipoAnonimo.contaCorrente}");

//Coleção tipo anonimo

string conteudoArquivoVendas = File.ReadAllText("Arquivos/vendas.json");

List<Venda> vendas = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivoVendas);

var listaAnonima = vendas.Select(x => new { x.Nome, x.Preco });

foreach (var venda in listaAnonima)
{
    Console.WriteLine($"Produto: {venda.Nome}, Preço: {venda.Preco}");
}