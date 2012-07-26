using System.IO;
using System.Xml.Serialization;
using QuartzHelper.XmlConfigEditor.Entities;

namespace QuartzHelper.XmlConfigEditor.Services
{
    internal static class XmlConfigService
    {
        private static readonly XmlSerializer _xmlSerializer;
        private static readonly XmlSerializerNamespaces _xmlSerializerNamespaces; 

        static XmlConfigService()
        {
            _xmlSerializer = new XmlSerializer(typeof(JobSchedulingData));
            
            _xmlSerializerNamespaces = new XmlSerializerNamespaces();
            _xmlSerializerNamespaces.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance");
        }

        public static void Save(JobSchedulingData data, string filename)
        {
            using (var sw = new StreamWriter(filename, false))
            {
                _xmlSerializer.Serialize(sw, data, _xmlSerializerNamespaces);
            }
        }

        public static JobSchedulingData Load(string filename)
        {
            JobSchedulingData data;

            using (var sw = new StreamReader(filename))
            {
                data = (JobSchedulingData)_xmlSerializer.Deserialize(sw);
            }

            return data;
        }
    }
}
