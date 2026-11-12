using UnityEngine;
using Environment;
using System;
using System.Collections;
using System.Collections.Generic;


public class BSTNode<t>
{
    private t data;
    public BSTNode<t>? leftChild = null;
    public BSTNode<t>? rightChild = null;

    public t GetData()
    {
        return data;
    }

    public BSTNode(t inData)
    {
        this.data = inData;
    }
}

public class BST
{
    public BSTNode<Employee> root;

    public BST(Employee rootData)
    {
        root = new BSTNode<Employee>(rootData);
    }

    public void Insert(Employee inData) //filling tree with data from Employee 
    {
        //assuming that values are unique
        BSTNode<Employee> newNode = new BSTNode<Employee>(inData);
        BSTNode<Employee>? currentNode = root;
        BSTNode<Employee> lastParent = root;
        while (currentNode != null)
        { // Keep searching until we find an empty child slot
            if (DateTime.ParseExact(inData.lastEntranceInEngineRoom, "yyyy-MM-ddTHH:mm:ss", System.Globalization.CultureInfo.InvariantCulture)
                < DateTime.ParseExact(currentNode.GetData().lastEntranceInEngineRoom, "yyyy-MM-ddTHH:mm:ss", System.Globalization.CultureInfo.InvariantCulture)  /*node we are examining*/)
            {
                lastParent = currentNode;
                currentNode = currentNode.leftChild;
            }
            else
            {
                lastParent = currentNode;
                currentNode = currentNode.rightChild;
            }
        }

        //we reached a point where lastParent has an empty child slot fitting newNode
        if (DateTime.ParseExact(inData.lastEntranceInEngineRoom, "yyyy-MM-ddTHH:mm:ss", System.Globalization.CultureInfo.InvariantCulture)
            < DateTime.ParseExact(lastParent.GetData().lastEntranceInEngineRoom, "yyyy-MM-ddTHH:mm:ss", System.Globalization.CultureInfo.InvariantCulture))
        {
            lastParent.leftChild = newNode;
        }
        else
        {
            lastParent.rightChild = newNode;
        }
    }

    public void Traverse()
    {
        Stack<BSTNode<Employee>> BSTStack = new Stack<BSTNode<Employee>>(); //create a new stack with the data from employees
        BSTNode<Employee> current = root;

        while (current != null || !(BSTStack.Count == 0))
        {
            while (current != null)
            {
                BSTStack.Push(current);
                current = current.leftChild;
            }

            current = BSTStack.Pop();
            Debug.Log("Name: " + current.GetData().name + "Last Entrance" + current.GetData().lastEntranceInEngineRoom + "");
            current = current.rightChild;
        }
    }
}



