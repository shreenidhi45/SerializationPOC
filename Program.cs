using System.Configuration;

namespace SerialDesrializePOC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                string xmlFilePath = ConfigurationManager.AppSettings["XmlFilePath"];
                

                // XML Serialization
                Employee empXml = new Employee();
                empXml.Id = 102;
                empXml.Name = "SHREE";

                XmlSerialization.Serialize(empXml, xmlFilePath);
                Employee empXmlDeserialized = XmlSerialization.Deserialize(xmlFilePath);
                Console.WriteLine("Deserialized XML: {0}, {1}", empXmlDeserialized.Id, empXmlDeserialized.Name);
            }
        }

    }
