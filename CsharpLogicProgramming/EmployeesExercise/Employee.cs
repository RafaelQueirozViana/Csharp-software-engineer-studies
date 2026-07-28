namespace EmployeesExercise {
    internal class Employee {

        public int Id { get; private set; }
        public string Name { get; private set; }
        public double Salary { get; private set; }

        public Employee(int id, string name, double salary) {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void salaryIncrease(double percentage) {
            Salary += Salary * (percentage / 100);
        }


    }
}
