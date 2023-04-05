using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementBehaviour : MonoBehaviour
{
    private Rigidbody _rb;
    private Vector2 _moveDirection;

    [SerializeField]
    private float _acceleration;
    [SerializeField]
    private float _maxSpeed;
    [SerializeField]
    private float _jumpPower;
    [SerializeField]
    private GroundColliderBehaviour _groundCollider;

    // Start is called before the first frame update

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    public void SetMoveDirection(Vector3 direction)
    {
        _moveDirection = direction;
    }

    public void Jump()
    {
        if (_groundCollider.IsGrounded)
            _rb.AddForce(Vector3.up * _jumpPower, ForceMode.Impulse);
    }

    // Update is called once per frame

    private void FixedUpdate()
    {
        float acceleration = _acceleration;

        if (!_groundCollider.IsGrounded)

        _rb.AddForce(_moveDirection * acceleration * Time.deltaTime, ForceMode.VelocityChange);        
    }
}
