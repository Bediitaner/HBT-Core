using UnityEngine;

namespace RedAsh.Core.Services
{
    public abstract class RServiceBehaviour : MonoBehaviour, IRService
    {
        #region Build > OnBuild

        public void Build()
        {
            OnBuild();
        }

        protected abstract void OnBuild();

        #endregion

        #region Begin > OnBegin

        public void Begin()
        {
            OnBegin();
        }
        
        protected abstract void OnBegin();

        #endregion

        #region ReBegin > OnReBegin

        public void ReBegin()
        {
            OnReBegin();
        }
        
        protected abstract void OnReBegin();

        #endregion

        #region End > OnEnd

        public void End()
        {
            OnEnd();
        }

        protected abstract void OnEnd();

        #endregion
    }
}