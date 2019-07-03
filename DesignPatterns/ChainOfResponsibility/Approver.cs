namespace DesignPatterns.ChainOfResponsibilities
{
    //Handler  abstract class  
    abstract class Approver
    {
        protected Approver successor;
        public void SetSuccessor(Approver successor)
        {
            this.successor = successor;
        }
        public abstract void ProcessRequest(Project Project);
    }
}
