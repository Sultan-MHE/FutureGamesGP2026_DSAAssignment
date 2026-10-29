using UnityEngine;
namespace Environment.Tasks
{
    [CreateAssetMenu(fileName = "EmployeeLogTask", menuName = "EmployeeLogTask")]
    public class EmployeeLogTask : Task
    {
        [SerializeField]
        private TextAsset jsonFile = null;

        public override void Execute()
        {
            if (jsonFile == null)
            {
                return;
            }
            EmployeeManager.Instance.Employees = JsonUtility.FromJson<EmployeeArray>(jsonFile.text)?.employees;

            if (EmployeeManager.Instance.Employees != null && EmployeeManager.Instance.Employees.Length <= 0)
            {
                return;
            }

            foreach (Employee employee in EmployeeManager.Instance.Employees)
            {
                employee.Intialize(); //converting string to datetime
                Debug.Log("Name: " + employee.name);
                Debug.Log("Employee ID: " + employee.employeeId);
                Debug.Log("Clearance: " + employee.hasEngineRoomClearance);
                Debug.Log("Last Entrance: " + employee.lastEntranceInEngineRoom);
                Debug.Log("Last Exit: " + employee.lastExitFromEngineRoom);

            }
        }
    }
}