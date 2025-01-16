using NEDDY.Tools;
using UnityEngine;

namespace NEDDY
{
    /// <summary>
    /// 狀態基底
    /// </summary>
    public class StateBase:MonoBehaviour,IState
    {
        protected string stateName;
        public virtual void EnterState()
        {
            
        }
    }
}