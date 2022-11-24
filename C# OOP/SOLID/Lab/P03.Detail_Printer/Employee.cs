namespace P03.DetailPrinter
{
    public class Employee
    {
        public Employee(string name)
        {
            this.Name = name;
        }

        public string Name { get; private set; }

        public bool HasDocuments { get; protected set; }
    }
}