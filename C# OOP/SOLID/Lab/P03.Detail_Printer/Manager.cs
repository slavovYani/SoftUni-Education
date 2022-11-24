namespace P03.DetailPrinter
{
    using System.Collections.Generic;

    public class Manager : Employee
    {
        public Manager(string name, ICollection<string> documents)
            : base(name)
        {
            this.Documents = new List<string>(documents);
            HasDocuments = true;
        }

        public IReadOnlyCollection<string> Documents { get; }
    }
}
