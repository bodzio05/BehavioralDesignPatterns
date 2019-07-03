namespace DesignPatterns.Iterator2
{
    //The 'Iterator' interface
    interface IAbstractIterator
    {
        Item First();
        Item Next();
        bool IsDone { get; }
        Item CurrentItem { get; }  
    }
}
