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

            Employee[] employees = JsonUtility.FromJson<EmployeeArray>(jsonFile.text)?.employees;

            if (employees != null && employees.Length <= 0)
            {
                return;
            }

            foreach (Employee employee in employees)
            {
                Debug.Log("Name: " + employee.name);
                Debug.Log("Employee ID: " + employee.employeeId);
                Debug.Log("Clearance: " + employee.hasEngineRoomClearance);
                Debug.Log("Last Entrance: " + employee.lastEntranceInEngineRoom);
                Debug.Log("Last Exit: " + employee.lastExitFromEngineRoom);

            }
        }
    }
}