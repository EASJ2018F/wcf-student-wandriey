using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfServiceStudent
{
    public class Student :Ikey
    {
        private string _navn;
        private string _klassenavn;
        private int _rum;
        private int _telefonKey;




        public Student(string navn, string klassenavn, int rum, int telefonKey)
        {
            _navn = navn;
            _klassenavn = klassenavn;
            _rum = rum;
        }

        public string Name { get { return _navn; } set { _navn = value; } }
        public string Klassenavn { get { return _klassenavn; } set { _klassenavn = value; } }
        public int Rum { get { return _rum; } set { _rum = value; } }
        public int Key { get { return _telefonKey; } set { _telefonKey = value; } }
    }
}