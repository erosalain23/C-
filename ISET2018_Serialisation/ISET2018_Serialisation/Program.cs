using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Xml;

namespace ISET2018_Serialisation
{
    class Program
    {
        static void Main(string[] args)
        {
            #region PersnonnaPersonnalisee
            PersonneSerialisee ps = new PersonneSerialisee(1, "Winch", "Largo",new DateTime(1975, 07, 15));
            ps.Lst.Add("Danitza");
            ps.Lst.Add("Charity");
            ps.Lst.Add("Marilyn");
            ps.SerialiserFchier("essai.xml");
            PersonneSerialisee psBis = PersonneSerialisee.DeSerialiserFichier("essai.xml");
            Console.WriteLine("{0} {1} ({2})", psBis.Prenom, psBis.Nom, psBis.ID);
            #endregion
            #region Personne
            Personne p = new Personne(1, "Winch", "Largo",new DateTime(1975, 07, 15));
            p.Lst.Add("Danitza");
            p.Lst.Add("Charity");
            p.Lst.Add("Marilyn");
            p.SerialiserFichier("essaibis.xml");
            Personne pBis = Personne.DeSerialiserFichier("essaibis.xml");
            Console.WriteLine("{0} {1} ({2})", psBis.Prenom, psBis.Nom, psBis.ID);
            p.SerialiserToutFichier("essaiter.xml");
            Personne pTer = Personne.DeserialiserToutFichier("essaiter.xml");
            Console.WriteLine("{0} {1} ({2})", pTer.Prenom, pTer.Nom, pTer.ID);
            #endregion
            #region Generique
            UtilitaireSerialisation.SerialiserToutFichier<Personne>("essai4.xml", p);
            Personne pQuat = UtilitaireSerialisation.DeserialiserToutFichier<Personne>("essai4.xml");
            Console.WriteLine("{0} {1} {2}", pQuat.Prenom, pQuat.Nom, pQuat.ID);
            List<Personne> lPers = new List<Personne>();
            lPers.Add(p);
            lPers.Add(pBis);
            lPers.Add(pTer);
            lPers.Add(pQuat);
            UtilitaireSerialisation.SerialiserToutFichier<List<Personne>>("essai5.xml",lPers);
            #endregion
            Console.ReadLine();
        }
    }
    [Serializable]
    [XmlRoot()]
    public class PersonneSerialisee
    {
        [XmlAttribute("Indentifiant")]
        public int ID { get; set; }
        [XmlElement("Nom")]
        public string Nom { get; set; }
        [XmlElement("Prenom")]
        public string Prenom { get; set; }
        [XmlIgnore()]
        public DateTime Naissance { get; set; }
        [XmlArray("Liste")]
        [XmlArrayItem("Conquete")]
        public List<string> Lst { get; set; }
        public PersonneSerialisee()
        {Lst = new List<string>(); }

        public PersonneSerialisee(int ID_, string Nom_, string Prenom_, DateTime Naissance_):this()
        {
            ID = ID_;
            Nom = Nom_;
            Prenom = Prenom_;
            Naissance = Naissance_;
        }
        public void SerialiserFchier(string nf)
        {
            using (StreamWriter sw = new StreamWriter(nf))
            {
                XmlSerializer xs = new XmlSerializer(this.GetType());
                xs.Serialize(sw, this);
                sw.Close();
            }
        }
        public static PersonneSerialisee DeSerialiserFichier(string nf)
        {
            using (StreamReader sr = new StreamReader(nf))
            {
                XmlSerializer xs = new XmlSerializer(typeof(PersonneSerialisee));
                PersonneSerialisee rep = (PersonneSerialisee)xs.Deserialize(sr);
                sr.Close();
                return rep;
            }
        }
    }
    public class Personne
    {
        [XmlAttribute("Indentifiant")]
        public int ID { get; set; }
        [XmlElement("Nom")]
        public string Nom { get; set; }
        [XmlElement("Prenom")]
        public string Prenom { get; set; }
        [XmlIgnore()]
        public DateTime Naissance { get; set; }
        [XmlArray("Liste")]
        [XmlArrayItem("Conquete")]
        public List<string> Lst { get; set; }
        public Personne()
        { Lst = new List<string>(); }
        public Personne(int ID_, string Nom_, string Prenom_, DateTime Naissance_) : this()
        {
            ID = ID_;
            Nom = Nom_;
            Prenom = Prenom_;
            Naissance = Naissance_;
        }
        public void SerialiserFichier(string nf)
        {
            using (XmlTextWriter xw = new XmlTextWriter(nf, Encoding.UTF8))
            {
                xw.WriteStartDocument();
                xw.WriteStartElement("Personne");
                xw.WriteAttributeString("Identifiant", ID.ToString());
                xw.WriteElementString("Prenom", Prenom);
                xw.WriteElementString("Nom", Nom);
                xw.WriteStartElement("Liste");
                foreach (string l in Lst)
                    xw.WriteElementString("Conquete", l);
                xw.WriteEndElement();
                xw.WriteEndElement();
                xw.WriteEndDocument();
                xw.Close();
            }
        }
        public static Personne DeSerialiserFichier(string nf)
        {
            Personne rep = new Personne();
            XmlTextReader xr = new XmlTextReader(nf);
            while (xr.Read())
            {
                if (xr.Name == "personne")
                {
                    xr.MoveToAttribute("Indentifiant");
                    rep.ID = xr.ReadContentAsInt();
                    xr.Read();
                    rep.Prenom = xr.ReadElementContentAsString();
                    rep.Nom = xr.ReadElementContentAsString();
                    if (xr.Name == "Liste" && !xr.IsEmptyElement)
                    {
                        xr.Read();
                        while (xr.Name == "Conquete")
                            rep.Lst.Add(xr.ReadElementContentAsString());
                    }
                    xr.Read();
                }
            }
            xr.Close();
            return rep;
        }
        public void SerialiserToutFichier(string nf)
        {
            XmlSerializer xs = new XmlSerializer(this.GetType());
            StreamWriter sw = new StreamWriter(nf);
            xs.Serialize(sw, this);
            sw.Close();
        }
        public static Personne DeserialiserToutFichier(string nf)
        {
            XmlSerializer xs = new XmlSerializer(typeof(Personne));
            StreamReader sr = new StreamReader(nf);
            Personne rep = (Personne)xs.Deserialize(sr);
            sr.Close();
            return rep;
        }
    }
    public class UtilitaireSerialisation
    {
        public static void SerialiserToutFichier<T>(string nf,T obj)
        {
            XmlSerializer xs = new XmlSerializer(typeof(T));
            StreamWriter sw = new StreamWriter(nf);
            xs.Serialize(sw, obj);
            sw.Close();
        }
        public static T DeserialiserToutFichier<T>(string nf)
        {
            XmlSerializer xs = new XmlSerializer(typeof(T));
            StreamReader sr = new StreamReader(nf);
            T rep = (T)xs.Deserialize(sr);
            sr.Close();
            return rep;
        }
    }
    
}
