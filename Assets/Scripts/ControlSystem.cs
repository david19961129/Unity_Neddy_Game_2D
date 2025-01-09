using UnityEngine;

namespace NEDDY
{
    /// <summary>
    /// 控制系統
    /// </summary>
    public class ControlSystem : MonoBehaviour
    {
        [SerializeField, Header("移動速度"), Tooltip("調整移動速度"), Range(0, 10)]
        //修飾詞  類型 名稱 (指定 預設值)
        private float moveSepped = 3.5f;

        private Rigidbody2D rig;
        private Animator ani;
        private string parMove = "移動數值";

        private void Awake()
        {
            //取得物件上2D剛體元並存至 rig 變數
            rig = GetComponent<Rigidbody2D>();
            ani = GetComponent<Animator>();
        }

        private void Update()
        {
            float h = Input.GetAxis("Horizontal");
            rig.linearVelocity = new Vector2(h * moveSepped, rig.linearVelocity.y);
            ani.SetFloat(parMove,Mathf.Abs(h));
        }
    }
}