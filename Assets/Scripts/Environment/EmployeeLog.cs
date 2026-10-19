using Environment;
using System;
using UnityEngine;

namespace Environment
{
    [Serializable]
    public class Employee
    {
        public string name;
        public int employeeId;
        public bool hasEngineRoomClearance;
        public string lastEntranceInEngineRoom; //challenge: dont save this as a string :3
        public string lastExitFromEngineRoom;
    }

    //public class EmployeeLog<T>
    //{
    //    [SerializeField]
    //    private TextAsset jsonFile = null;

    [Serializable]
    public class EmployeeArray
    {
        public Employee[] employees;
    }

    //public T EmployeeLogPrint()
    //{

    //    if (jsonFile == null)
    //    {
    //        return T;
    //    }

    //    Employee[] employees = JsonUtility.FromJson<EmployeeArray>(jsonFile.text)?.employees;

    //    if (employees != null && employees.Length <= 0)
    //    {
    //        //  return;
    //    }

    //    foreach (Employee employee in employees)
    //    {
    //        Debug.Log("Name: " + employee.name);
    //        Debug.Log("Employee ID: " + employee.employeeId);
    //        Debug.Log("Clearance: " + employee.hasEngineRoomClearance);
    //        Debug.Log("Last Entrance: " + employee.lastEntranceInEngineRoom);
    //        Debug.Log("Last Exit: " + employee.lastExitFromEngineRoom);

    //    }
    //}

}





