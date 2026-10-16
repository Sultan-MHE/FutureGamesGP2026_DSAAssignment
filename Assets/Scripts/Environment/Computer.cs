using Environment.Tasks;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Environment
{
    public class Computer : MonoBehaviour, IInteractable
    {
        [SerializeField]
        public GenericQueue<Task> taskQueue = new GenericQueue<Task>(); // Put your stack/queue here :)


        public void OnInteract()
        {
            
            // way 1
            Task task = taskQueue.Dequeue();
            task.Execute();

            // way 2 (does the same thing but limits you so you cant do anything between Dequeue and Execute)
            // taskQueue.Dequeue().Execute();

        }
    }
}
