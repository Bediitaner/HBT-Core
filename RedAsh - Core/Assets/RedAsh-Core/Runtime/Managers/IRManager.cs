namespace RedAsh.Core.Managers
{
    public interface IRManager
    {
        void Build();
        void Begin();
        void ReBegin();
        void Register();
        void UnRegister();
        void End();
    }
}