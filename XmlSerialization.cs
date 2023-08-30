using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SerialDesrializePOC
{
    internal class XmlSerialization
    {
        public static void Serialize(Employee employee, string filePath)
        {
            using (FileStream stream = File.Create(filePath))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Employee));
                serializer.Serialize(stream, employee);
            }
        }

        public static Employee Deserialize(string filePath)
        {
            using (FileStream stream = File.OpenRead(filePath))
            {
                XmlSerializer deserializer = new XmlSerializer(typeof(Employee));
                return (Employee)deserializer.Deserialize(stream);
            }
        }
    }
}
