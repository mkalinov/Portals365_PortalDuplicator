using System;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace DMM365.Helper
{
    public static class IOHelper
    {


        internal static bool isFileExist(string path, string extensionToCheck = "")
        {
            if (!File.Exists(path)) return false;
            if (!GlobalHelper.isValidString(extensionToCheck))
                return true;
            string ext = extensionToCheck.Substring(0, 1) == "." ? extensionToCheck : "." + extensionToCheck;
            if (Path.GetExtension(path) != ext)
                return false;

            return true;
        }
        

        /// <summary>
        /// Object to XML string
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        internal static string SerializeToXmlString<T>(object obj)
        {
            string result = string.Empty;

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            using (StringWriter objectReader = new StringWriter())
            {
                xmlSerializer.Serialize(objectReader, obj);
                result = objectReader.ToString();
            }

            return result;
        }


        /// <summary>
        /// Deserialize and load Xml from file of an xml string
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="path"></param>
        /// <returns></returns>
        internal static T DeserializeXmlFromFile<T>(string path)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            using (TextReader textReader = new StreamReader(path))
            {
                return (T)xmlSerializer.Deserialize(textReader);
            }
        }


        /// <summary>
        /// Object to xml file
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <param name="pathWithFileName"></param>
        /// <returns></returns>
        internal static void SerializeObjectToXmlFile<T>(object obj, string pathWithFileName)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            using (FileStream file = File.OpenWrite(pathWithFileName))
            {
                xmlSerializer.Serialize(file, obj);
            }
        }


        /// <summary>
        /// JSON to object of type T
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="json"></param>
        /// <returns></returns>
        internal static T DeserializeJsonObject<T>(string json)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(T));
                StreamWriter writer = new StreamWriter(stream);
                writer.Write(json);
                writer.Flush();
                stream.Position = 0;
                T responseObject = (T)serializer.ReadObject(stream);
                return responseObject;
            }
        }


        /// <summary>
        /// Object of type T to JSON
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        internal static string SerializeObjectToJson<T>(object obj)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(T));
                serializer.WriteObject(stream, obj);
                return Encoding.UTF8.GetString(stream.ToArray());
                //stream.Position = 0;
                //StreamReader reader = new StreamReader(stream);
                //string requestBody = reader.ReadToEnd();
                //return requestBody;
            }
        }

        internal static void clearDirectory(string directoryPath)
        {
            DirectoryInfo dir = new DirectoryInfo(directoryPath);

            foreach (FileInfo files in dir.GetFiles())
            {
                foreach (FileInfo file in dir.GetFiles())
                    file.Delete();
                foreach (DirectoryInfo subDirectory in dir.GetDirectories())
                    dir.Delete(true);
            }
        }

        internal static DirectoryInfo createDirectory(string path)
        {
            if (Directory.Exists(path)) return new DirectoryInfo(path);
            try
            {
                return Directory.CreateDirectory(path);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


    }
}
