namespace Visitor
{
    public interface IVisitor
    {
        void Visit(BackOfficeEmployee e);
        void Visit(SaleEmployee e);
    }
}