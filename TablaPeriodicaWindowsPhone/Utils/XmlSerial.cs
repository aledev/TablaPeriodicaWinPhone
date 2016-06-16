using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace TablaPeriodicaWindowsPhone.Utils
{
    public class XmlSerial
    {
        ////Objeto para Desserializar contenido xml
        //public T DesSerializeObjeto<T>(string xmlObject)
        //{


        //    // <typeparam name="T">tipo de objeto al cual se desea dessrializara</typeparam>
        //    // <param name="xmlObject">objeto para desserializar (xml)</param>

        //        T dtoSerializado;

        //        XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
        //        StringReader stringReader = new StringReader(xmlObject);
        //        XmlTextReader xmlTextReader = new XmlTextReader(stringReader);
        //        XDocument xdoc = new XDocument();
        //        XDocument xdoc = XDocument.Load(

        //        dtoSerializado = (T)xmlSerializer.Deserialize(xmlTextReader);
        //        xmlTextReader.Close();
        //        stringReader.Close();
            

        //    return dtoSerializado;
        //}

        ////Objeto para Serializar contenido XML
        //public string SerializeObjeto<T>(T objeto)
        //{
        //    // <typeparam name="T">tipo de objeto al cual se desea serializara</typeparam>
        //    // <param name="p_Dto"></param>

        //    String dtoSerializado = string.Empty;

        //    StringWriter stringWriter = new StringWriter();

        //    XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
        //    XmlSerializerNamespaces xmlNamespaces = new XmlSerializerNamespaces();
        //    xmlNamespaces.Add("", "");

        //    using (XmlWriter writer = XmlWriter.Create(stringWriter, new XmlWriterSettings { OmitXmlDeclaration = true }))
        //    {
        //        //new XmlSerializer(typeof(T)).Serialize(writer, objeto, xmlNamespaces);
        //        xmlSerializer.Serialize(writer, objeto, xmlNamespaces);
        //    }

        //    //StringWriter  stringWriter = new StringWriter();
        //    //xmlSerializer.Serialize(stringWriter, objeto, xmlNamespaces);
        //    dtoSerializado = stringWriter.ToString();
        //    stringWriter.Close();


        //    return dtoSerializado;
        //}
    }
}