// IVisitor.cs
public interface IVisitor
{
    void Visit(Player player);
    void Visit(Enemy enemy);
    void Visit(Item item);
}
