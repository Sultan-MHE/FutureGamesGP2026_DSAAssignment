using System.Diagnostics;
using UnityEngine;
namespace Environment.Tasks
{
    [CreateAssetMenu(fileName = "SearchTask", menuName = "SearchTask")]
    public class Search : Task
    {
        public override void Execute()
        {
            Stopwatch stopWatch = new Stopwatch(); //benchmarking code 
            stopWatch.Start();

            Employee[] outputArray = BinarySearch.EmployeesInDateTimeRange(EmployeeManager.Instance.Employees, 
                new System.DateTime(2234, 08, 07, 20, 44, 44), new System.DateTime(2234, 04, 07, 20, 44, 44));

            foreach (Employee employee in outputArray)
            {
                employee.Intialize(); //converting string to datetime
                UnityEngine.Debug.Log("Name: " + employee.name);
                UnityEngine.Debug.Log("Last Exit: " + employee.lastExitFromEngineRoom);
            }
            stopWatch.Stop();
            UnityEngine.Debug.Log("It took " + stopWatch.ElapsedMilliseconds + "ms");
        }
    }
}

