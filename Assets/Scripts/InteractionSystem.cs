using UnityEngine;

namespace NEDDY
{
    /// <summary>
    /// 互動系統
    /// </summary>
    public class InteractionSystem:MonoBehaviour
    {
        //觸發事件
        //collision 儲存碰到物件的碰撞資訊
        private void OnTriggerEnter2D(Collider2D collision)
        {
            Debug.Log(collision.name);
        }
    }
}
