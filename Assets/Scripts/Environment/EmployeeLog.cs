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

        public DateTime lastEntranceInEngineRoomDateTime;
        public DateTime lastExitFromEngineRoomDateTime;


        public void Intialize() //converting string to datetime
        {
            lastEntranceInEngineRoomDateTime = DateTime.Parse(lastEntranceInEngineRoom);
            lastExitFromEngineRoomDateTime = DateTime.Parse(lastExitFromEngineRoom);
        }
    }
    [Serializable]
    public class EmployeeArray
    {
        public Employee[] employees;
    }

}





