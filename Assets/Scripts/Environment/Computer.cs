using Environment.Tasks;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Environment
{

    public class Computer : MonoBehaviour, IInteractable
    {
        [SerializeField]
          //public EmployeeLog<Task> taskEmployeeLog = new EmployeeLog<Task>();

        public GenericQueue<Task> taskQueue = new GenericQueue<Task>(); // Put your stack/queue here :)


        public void OnInteract()
        {
            //Task employeeTask = taskEmployeeLog.EmployeeLogPrint;

            // way 1
            //Task task = taskQueue.Dequeue();
            //task.Execute();

            // way 2 (does the same thing but limits you so you cant do anything between Dequeue and Execute)
            taskQueue.Dequeue().Execute();

        }
    }
}
