using Environment;
using System;
using UnityEngine;
using UnityEngine.UIElements;
using System.Diagnostics;

public class BinarySearch
{
    public static Employee[] EmployeesInDateTimeRange(Employee[] employees,
        DateTime inputLowerRange, DateTime inputUpperRange)
    {

        int indexLowerRange = 0;
        int indexUpperRange = employees.Length - 1; //set the max size of the range

        int left = 0;
        int right = employees.Length - 1; //set the max size of the index

        int middle = 0;

       

        while (left <= right) //while there are still values inside the index
        {
 
            middle = (left + right) / 2; //halve it and make the middle value 'middle'

            if (employees[middle].lastEntranceInEngineRoomDateTime >= inputLowerRange) //if the middle value is greater than the input lower range
            {
                indexLowerRange = middle; //set the lower range as the middle 
            }

            if (employees[middle].lastEntranceInEngineRoomDateTime < inputLowerRange) //if the middle value is less than the input lower range
                left = middle + 1; //
            else
                right = middle - 1; //
        }
        //resetting the values to use them again (maybe?)
        left = 0;
        right = employees.Length - 1;

        middle = 0;
        //same thing as the above code but checking everything against the input upper range instead
        while (left <= right)
        {
            middle = (left + right) / 2;

            if (employees[middle].lastEntranceInEngineRoomDateTime <= inputUpperRange)
            {
                indexUpperRange = middle;
            }

            if (employees[middle].lastEntranceInEngineRoomDateTime > inputUpperRange)
                left = middle + 1;
            else
                right = middle - 1;
        }

        Employee[] employeeRange = new Employee[indexUpperRange - indexLowerRange + 1]; //making a new array

        int k = 0;

        for (int i = indexLowerRange; i <= indexUpperRange; i++) //for everything between indexLR and indexUR
        {
            employeeRange[k++] = employees[i]; //populate the new array with the values from employees that are within the set range
            
        }

        return employeeRange; //return new array 

    }
}