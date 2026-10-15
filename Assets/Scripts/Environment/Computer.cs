using Environment.Tasks;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Environment {
    public class Computer : MonoBehaviour, IInteractable {
        // [SerializeField]

        int interactionCounter;
        private Queue<int> commands = new Queue<int>();
        //private Task testTask = null; // Put your stack/queue here :)

        //build your own queueueueueu 

        public void OnInteract() {

            commands.Enqueue(interactionCounter);

            if(interactionCounter == 0) {
                Debug.Log("Welcome! This is your first time here");
                interactionCounter = 1;
            }

            else {
                Debug.Log("You have logged in " + commands.Dequeue() + " times :)");
                interactionCounter++;
            }
            //testTask.Execute();

            //TEST
        }
    }
}
