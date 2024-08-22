using System.Text.Json;


Pessoa pessoa = new Pessoa { Nome = "João", Idade = 30 };

// Serializar para JSON
string jsonString = JsonSerializer.Serialize(pessoa);
File.WriteAllText("pessoa.json", jsonString);
Console.WriteLine("Objeto serializado para JSON.");

// Desserializar do JSON
string jsonFromFile = File.ReadAllText("pessoa.json");
Pessoa pessoaDesserializada = JsonSerializer.Deserialize<Pessoa>(jsonFromFile);
Console.WriteLine($"Nome: {pessoaDesserializada.Nome}, Idade: {pessoaDesserializada.Idade}");


public class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }
}