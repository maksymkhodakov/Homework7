namespace DesignPatterns;

// "Component"
internal abstract class AbstractTreeDecoration
{
    public abstract void DecorationOperation();
}

// "ConcreteComponent"
internal class ConcreteTreeComponent : AbstractTreeDecoration
{
    public override void DecorationOperation()
    {
        Console.WriteLine("LIGHT!");
    }
}
// "Decorator"
internal abstract class Decorator : AbstractTreeDecoration
{
    protected AbstractTreeDecoration AbstractTreeDecoration;

    public void SetComponent(AbstractTreeDecoration abstractTreeDecoration)
    {
        this.AbstractTreeDecoration = abstractTreeDecoration;
    }
    public override void DecorationOperation()
    {
        if (AbstractTreeDecoration != null)
        {
            AbstractTreeDecoration.DecorationOperation();
        }
    }
}
    
// "ConcreteDecorator" as tree
internal class Tree : Decorator
{
    public override void DecorationOperation()
    {
        base.DecorationOperation();
        AddedBehavior();
        Console.WriteLine("Decoration Tree!");
    }

    void AddedBehavior()
    {
        Console.WriteLine("we are inside of a tree decorator!");
    }
}