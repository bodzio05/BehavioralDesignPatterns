// todo: fix namespace
namespace DesignPatterns.Commands
{
    public interface ICommand
    {
        void Call();
        void Undo();
    }
}
