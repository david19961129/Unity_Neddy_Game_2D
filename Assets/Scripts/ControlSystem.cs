using UnityEngine;
using UnityEngine.InputSystem;

public class ControlSystem : MonoBehaviour
{
    [SerializeField] private float _speed = 10f;

    private Vector2 _moveInput;
    private Rigidbody2D _rigidbody;

    private void Start()
    {
        _rigidbody=GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        _rigidbody.linearVelocity =_moveInput*_speed;
    }


    private void onMove(InputValue value)
    {
        _moveInput=value.Get<Vector2>();
    }
}
