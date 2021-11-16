namespace CommandList
{
    interface ICommand
    {
        void Run();
        char Key { get; }
    }
}
