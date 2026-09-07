namespace EmployeesExercise {
    internal class Program {
        static void Main(string[] args) {

            List<Employee> employeesList = new List<Employee>();

            Console.WriteLine("How many employees will be registered?");
            int registeredEmployees = int.Parse(Console.ReadLine());

            for (int i = 1; i <= registeredEmployees; i++) {

                int choosedId;
                string choosedName;
                double choosedSalary;

                Console.WriteLine($"Register the employee {i}");

                Console.Write("ID: ");
                choosedId = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                choosedName = Console.ReadLine();

                Console.Write("Salary: ");
                choosedSalary = double.Parse(Console.ReadLine());

                employeesList.Add(new Employee(choosedId, choosedName, choosedSalary));

            }

            Console.Write("Type the employee id that will have the increase: ");
            int idToIncrease = int.Parse(Console.ReadLine());
            Employee employeeToIncrease = employeesList.Find(e => e.Id == idToIncrease);


            if (employeeToIncrease != null) {
                Console.Write("Type the percentage ");
                double percentage = double.Parse(Console.ReadLine());

                employeeToIncrease.salaryIncrease(percentage);

                showEmployees(employeesList);
            }

            else {
                Console.WriteLine("Error: this id doesn't exist");
            }
        }

        static void showEmployees(List<Employee> list) {
            foreach (Employee currentWorker in list) {
                Console.WriteLine($"{currentWorker.Id}, {currentWorker.Name}, ${currentWorker.Salary}");
            }
        }
    }
}
