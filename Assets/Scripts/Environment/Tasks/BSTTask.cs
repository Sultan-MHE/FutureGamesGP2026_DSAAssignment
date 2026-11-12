using UnityEngine;
using System.Diagnostics;
namespace Environment.Tasks
{
    [CreateAssetMenu(fileName = "BSTTask", menuName = "BSTTask")]
    public class BSTTask : Task
    {
        public override void Execute()
        {
            Stopwatch stopWatch = new Stopwatch(); //benchmarking code 
            stopWatch.Start();

            BST bst = new BST(EmployeeManager.Instance.Employees[0]);

            for (int i = 1; i < EmployeeManager.Instance.Employees.Length; i++)
            {
                bst.Insert(EmployeeManager.Instance.Employees[i]); 
            }

            bst.Traverse();
            stopWatch.Stop(); //put this at the end of whatever
            UnityEngine.Debug.Log("It took " + stopWatch.ElapsedMilliseconds + "ms");
        }
    }
}
