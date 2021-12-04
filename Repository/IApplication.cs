namespace Repository
{
    internal interface IApplication
    {
        IDataRepository DataRepository { get; set; }

        void Run();
    }
}