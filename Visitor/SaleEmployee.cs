namespace Visitor
{
    public class SaleEmployee : Employee , IElement
    {
        public decimal Commission { get; set; }
        public SaleEmployee(string name, decimal salary , decimal commission) : base(name, salary)
        {
            Commission = commission;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}