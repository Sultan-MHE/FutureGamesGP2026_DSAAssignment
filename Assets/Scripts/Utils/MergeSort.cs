using Environment;
using System;
using UnityEngine;

public static class MergeSort
{
  public static void dateTimeMergeSort(Employee[] employees, int left, int right)
  {
    if (!(left == right)) //stops it from running over and over again 
    {
      int middle = left + (right - left) / 2;

      dateTimeMergeSort(employees, left, middle); // split from the left to the middle
      dateTimeMergeSort(employees, middle + 1, right); // split from the middle +1 to the right

      merge(employees, left, middle, right); 
    }
  }

  public static void merge(Employee[] employees, int left, int middle, int right)
  {
    //determine the size of the two new temp arrays 
    int leftArraySize = middle - left + 1; 
    int rightArraySize = right - middle;

    //making the new temp arrays
    Employee[] leftEmployeeSide = new Employee[leftArraySize];
    Employee[] rightEmployeeSide = new Employee[rightArraySize];

    int i, j; 

    //populating the temp arrays with the values from employees
    for (i = 0; i < leftArraySize; i++)
    {
      leftEmployeeSide[i] = employees[left + i];
    }

    for (j = 0; j < rightArraySize; j++)
    {
      rightEmployeeSide[j] = employees[middle + 1 + j];
    }
    //reset i and j to 0 so we can use the values again 
    i = 0;
    j = 0;

    int k = left; //k = original employee array 

    while (i < leftArraySize && j < rightArraySize) 
    {
      if (leftEmployeeSide[i].lastExitFromEngineRoomDateTime <= rightEmployeeSide[j].lastExitFromEngineRoomDateTime) //check if the i value of left is less than the j value of right
      {
        employees[k++] = leftEmployeeSide[i++]; //replace the k value of employees with i and then "move to the next slot"
      }

      else
      {
        employees[k++] = rightEmployeeSide[j++]; //replace the k value of employees with j and then "move to the next slot"
      }
    }

    //keep going until both the left and right arrays have been emptied
    while (i < leftArraySize)
    {
      employees[k++] = leftEmployeeSide[i++];
    }
    while (j < rightArraySize)
    {
      employees[k++] = rightEmployeeSide[j++];
    }
  }
}
