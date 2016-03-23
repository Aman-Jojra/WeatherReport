using System;
using System.IO;
using System.Xml.Serialization;

namespace IAsset.WeatherReport.WebApi.Framework
{
    public class Helper
    {
        /// <summary>
        /// Deserialize string to Object of type T
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="input"></param>
        /// <returns></returns>
        public static T XMLDeserialize<T>(string input)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                T response;
                using (TextReader reader = new StringReader(input))
                {
                    response = (T)serializer.Deserialize(reader);
                }
                return response;
            }
            catch
            {
                return default(T);
            }
        }
    }
}