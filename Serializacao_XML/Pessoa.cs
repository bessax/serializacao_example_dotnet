using System.Xml.Serialization;

namespace Serializacao_XML;
public class Pessoa
{
    [XmlAttributeAttribute()]
    int idade;
    string nome;
    public int Idade { get => idade; set => idade = value; }
    public string Nome { get => nome; set => nome = value; }
}
