namespace RopeApp
{
    public interface ICommand
    {
        void ProcessCommand(bool hasArgs, string[] args);
    }
}