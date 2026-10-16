using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;
using System;

namespace Environment
{
    [Serializable]
    public class GenericQueue<T>
    {
        public List<T> queue;

        public GenericQueue()
        {
            queue = new List<T>();
        }

        public void Enqueue(T InNewElement)
        {
            queue.Add(InNewElement);
        }

        public T Peek()
        {
            if (queue.Count == 0)
            {
                throw new System.Exception("Queue is empty, cant peak");
            }
            return queue[0];
        }

        public T Dequeue()
        {
            if (queue.Count == 0)
            {
                throw new System.Exception("Queue is empty, cant dequeue");
            }

            T topOfQueue = queue[0];
            queue.RemoveAt(index: 0);
            return topOfQueue;
        }

        public void Clear()
        {
            queue.Clear();
        }

    }
}
