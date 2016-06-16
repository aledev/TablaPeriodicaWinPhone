using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Xml.Serialization;
using System.ComponentModel;

namespace TablaPeriodicaWindowsPhone.ViewModels
{
    [XmlRoot("ElementoDTO", Namespace="")]
    public class ElementoDTO : INotifyPropertyChanged
    {
        #region Atributos Privados
        private string _nombre;
        private string _simbolo;
        private int _numeroAtomico;
        private double _masaAtomica;
        #endregion

        #region Propiedades Publicas
        [XmlElement("Nombre")]
        public string Nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                if (value != _nombre)
                {
                    _nombre = value;
                    NotifyPropertyChanged("Nombre");
                }
            }
        }

        [XmlElement("Simbolo")]
        public string Simbolo
        {
            get
            {
                return _simbolo;
            }
            set
            {
                if (value != _simbolo)
                {
                    _simbolo = value;
                    NotifyPropertyChanged("Simbolo");
                }
            }
        }

        [XmlElement("NumeroAtomico")]
        public int NumeroAtomico
        {
            get
            {
                return _numeroAtomico;
            }
            set
            {
                if (value != _numeroAtomico)
                {
                    _numeroAtomico = value;
                    NotifyPropertyChanged("NumeroAtomico");
                }
            }
        }

        [XmlElement("MasaAtomica")]
        public double MasaAtomica
        {
            get
            {
                return _masaAtomica;
            }
            set
            {
                if (value != _masaAtomica)
                {
                    _masaAtomica = value;
                    NotifyPropertyChanged("MasaAtomica");
                }
            }
        }
        #endregion

        #region INotifyPropertyChanged Members
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (null != handler)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }
}
