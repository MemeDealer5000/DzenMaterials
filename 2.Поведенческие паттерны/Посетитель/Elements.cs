// Player.cs
public class Player : MonoBehaviour, IElement
{
    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }

    // Остальной код логики игрока
}

// Enemy.cs
public class Enemy : MonoBehaviour, IElement
{
    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }

    // Остальной код логики врага
}

// Item.cs
public class Item : MonoBehaviour, IElement
{
    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }

    // Остальной код логики предмета
}
