using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GradesCalculator
{
    public class AppSerializer
    {
        public List<DataToSave> ListOfDataToSave { get; set; }
        public int SumOfPoints { get; set; }
        public int SumOfGrades { get; set; }
        public double Average { get; set; }

        public AppSerializer()
        {
            ListOfDataToSave = new List<DataToSave>();
        }

        public void saveToFile()
        {
            string fileName = "appSerializer.xml";
            string filePath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName,
                @"Save\", fileName);

            using (Stream stream = new FileStream(filePath, FileMode.Create))
            {
                XmlSerializer serializer = new XmlSerializer(this.GetType());
                serializer.Serialize(stream, this);
            }
        }

        public static AppSerializer loadFromFile()
        {
            AppSerializer dataToLoad = null;

            string fileName = "appSerializer.xml";
            string filePath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName,
                @"Save\", fileName);

            try
            {
                using (Stream stream = new FileStream(filePath, FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(AppSerializer));
                    dataToLoad = serializer.Deserialize(stream) as AppSerializer;
                }
            }
            catch(Exception e)
            {
                dataToLoad = new AppSerializer();
            }
            //}

            return dataToLoad;
        }
    }
}
