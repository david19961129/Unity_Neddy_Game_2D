using UnityEngine;

namespace NEDDY
{
    public class ControlSystem : MonoBehaviour
    {
        [SerializeField, Header("移動速度"), Tooltip("用於調整速度"), Range(0, 10)] private float moveSpeed = 3.3f;

        private Rigidbody2D rig;
        private Animator ani;
        private string parMove = "移動數值";

        private void Awake()
        {
            rig = GetComponent<Rigidbody2D>();
            ani = GetComponent<Animator>();
        }

        private string parh = "H";
        private string parv = "V";

        private void Update()
        {
            Move();
            Filp();
        }

        private void Move()
        {
            float h = Input.GetAxis("Horizontal");
            float v = Input.GetAxis("Vertical");
            rig.linearVelocity = new Vector2(h, v) * moveSpeed;
            ani.SetFloat(parh, (h));
            ani.SetFloat(parv, (v));

        }


        private void Filp()
        {

        }
    }

}