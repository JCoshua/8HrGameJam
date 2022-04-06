using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovementBehavior : MonoBehaviour
{
    [SerializeField]
    private float _speed;
    private Rigidbody _objectRigidbody;
    private Vector3 _moveDirection;

    public Rigidbody ObjectRigidbody
    {
        get { return _objectRigidbody; }
    }

    public Vector3 MoveDirection
    {
        get { return _moveDirection; }
        set { _moveDirection = value; }
    }

    public virtual void Awake()
    {
        _objectRigidbody = GetComponent<Rigidbody>();
    }

    public virtual void FixedUpdate()
    {
        //Moves the Object
        Vector3 velocity = MoveDirection.normalized * _speed * Time.fixedDeltaTime;
        _objectRigidbody.MovePosition(transform.position + velocity);
    }
}
