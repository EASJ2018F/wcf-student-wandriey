﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceStudent
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService
    {

        [OperationContract]
        void AddStudent(string navn, string klassenavn, int rum, int telefonKey);


        [OperationContract]
        Dictionary<int ,Student> FindStudents(int telefonKey);


        [OperationContract]
        Dictionary<int, Student> GetAllStudent();


        [OperationContract]
        void RemoveStudent(int telefonKey);


        [OperationContract]
        Dictionary<int, Student> EditStudent(int telefonKey);
    }
}
