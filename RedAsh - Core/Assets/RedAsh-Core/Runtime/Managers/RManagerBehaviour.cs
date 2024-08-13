using UnityEngine;

namespace RedAsh.Core.Managers
{
    public abstract class RManagerBehaviour : MonoBehaviour, IRManager
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

        #region Register > OnRegister

        public void Register()
        {
            OnRegister();
        }

        protected abstract void OnRegister();

        #endregion

        #region UnRegister > OnUnRegister

        public void UnRegister()
        {
            OnUnRegister();
        }

        protected abstract void OnUnRegister();

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