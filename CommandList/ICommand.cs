namespace CommandList
{
    interface ICommand
    {
        void Run();
        char Key { get; }
        string Description { get; }
    }
}
