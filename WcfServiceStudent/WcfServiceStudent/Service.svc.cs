using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceStudent
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service : IService
    {
        private Dictionary<int, Student> _dictionary;
            public Service()
        {
            Dictionary<int, Student> _dictionary = new Dictionary<int, Student>();
            Student student1 = new Student("Jonas", "F3", 3, 1);
            Student student2 = new Student("kasper", "F3", 5, 2);
            Student student3 = new Student("Ian", "F3", 3, 3);
        }

        public void AddStudent(string navn, string klassenavn, int rum, int telefonKey)
        {
            _dictionary.Add(telefonKey, new Student(navn, klassenavn, rum, telefonKey));
        }

        public Dictionary<int, Student> EditStudent(int telefonKey)
        {
            throw new NotImplementedException();
        }

        public Dictionary<int, Student> FindStudents(int telefonKey)
        {
            throw new NotImplementedException();
        }

        public Dictionary<int, Student> GetAllStudent()
        {
            throw new NotImplementedException();
        }

        public void RemoveStudent(int telefonKey)
        {
            throw new NotImplementedException();
        }
    }
}
