using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Collections.ObjectModel;
using TablaPeriodicaWindowsPhone.ViewModels;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.IO;
using System.Xml;
using System.Linq;


namespace TablaPeriodicaWindowsPhone
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public MainViewModel()
        {
            this.Items = new ObservableCollection<ElementoDTO>();
        }

        /// <summary>
        /// Colección para objetos ItemViewModel.
        /// </summary>
        public ObservableCollection<ElementoDTO> Items { get; private set; }

        private string _sampleProperty = "Valor de propiedad Sample Runtime";
        /// <summary>
        /// Propiedad Sample ViewModel; esta propiedad se usa en la vista para mostrar su valor mediante un enlace
        /// </summary>
        /// <returns></returns>
        public string SampleProperty
        {
            get
            {
                return _sampleProperty;
            }
            set
            {
                if (value != _sampleProperty)
                {
                    _sampleProperty = value;
                    NotifyPropertyChanged("SampleProperty");
                }
            }
        }

        public bool IsDataLoaded
        {
            get;
            private set;
        }

        /// <summary>
        /// Crear y agregar unos pocos objetos ItemViewModel a la colección Items.
        /// </summary>
        public void LoadData()
        {
            XDocument loadedData = XDocument.Load("SampleData/TablaPeriodicaData.xml");

            List<ElementoDTO> data = (from query in loadedData.Descendants("ElementoDTO")
                        select new ElementoDTO
                        {
                            Simbolo = (string)query.Element("Simbolo").Value,
                            Nombre = (string)query.Element("Nombre").Value,
                            MasaAtomica = double.Parse(query.Element("MasaAtomica").Value.Replace(",", ".")),
                            NumeroAtomico = int.Parse(query.Element("NumeroAtomico").Value)
                        }
                        ).ToList();

            foreach (ElementoDTO el in data)
            {
                Items.Add(el);
            }
           
            this.IsDataLoaded = true;
        }

        /// <summary>
        /// Crear y agregar unos pocos objetos ItemViewModel a la colección Items.
        /// </summary>
        public void LoadData(string filtro)
        {
            XDocument loadedData = XDocument.Load("SampleData/TablaPeriodicaData.xml");

            List<ElementoDTO> data = (from query in loadedData.Descendants("ElementoDTO")
                                      where ((query.Element("Nombre").Value.ToLower().Contains(filtro.ToLower())) ||
                                             (query.Element("Simbolo").Value.ToLower().Contains(filtro.ToLower())))
                                      select new ElementoDTO
                                      {
                                          Simbolo = (string)query.Element("Simbolo").Value,
                                          Nombre = (string)query.Element("Nombre").Value,
                                          MasaAtomica = double.Parse(query.Element("MasaAtomica").Value.Replace(",", ".")),
                                          NumeroAtomico = int.Parse(query.Element("NumeroAtomico").Value)
                                      }
                                      ).ToList();

            Items.Clear();

            foreach (ElementoDTO el in data)
            {
                Items.Add(el);
            }

            this.IsDataLoaded = true;
        }


        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (null != handler)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}