using Serializacao_XML;
using System.Xml.Serialization;


Pessoa p = new Pessoa { Idade = 32, Nome = "André" };

SaveToXML(p, "C:\\tmp\\" + p.Nome + ".xml");

void SaveToXML(object obj, string xml)
{
    FileStream stream = new FileStream(xml, FileMode.Create);
    XmlSerializer serializador = new XmlSerializer(obj.GetType());
    serializador.Serialize(stream, obj);
    stream.Close();
}