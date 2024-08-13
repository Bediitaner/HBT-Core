namespace RedAsh.Core.Services
{
    public interface IRService
    {
        void Build();
        void Begin();
        void ReBegin();
        void End();
    }
}