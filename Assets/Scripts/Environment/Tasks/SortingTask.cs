using UnityEngine;
namespace Environment.Tasks
{
  [CreateAssetMenu(fileName = "SortingTask", menuName = "SortingTask")]
  public class SortingTask : Task
  {
    public override void Execute()
    {
      MergeSort.dateTimeMergeSort(EmployeeManager.Instance.Employees, 0, EmployeeManager.Instance.Employees.Length - 1); //subtract the 1 because arrays start at 0 not at 1

      foreach (Employee employee in EmployeeManager.Instance.Employees)
      {
        employee.Intialize(); //converting string to datetime
        Debug.Log("Name: " + employee.name);
        Debug.Log("Last Exit: " + employee.lastExitFromEngineRoom);
      }
    }
  }
}


