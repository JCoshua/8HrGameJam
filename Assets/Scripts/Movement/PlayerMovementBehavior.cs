using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementBehavior : MonoBehaviour
{
    [SerializeField]
    private float _speed;
    [SerializeField]
    private float _rotationSpeed;
    private Rigidbody _rigidbody;
    private Vector3 _moveDirection;
    private Vector3 _rotationDirection;
    private Camera _camera;
    private float rotDirection = 0;

    public Vector3 MoveDirection
    {
        get { return _moveDirection; }
        set { _moveDirection = value; }
    }

    public Vector3 MouseDirection
    {
        get { return _rotationDirection; }
        set { _rotationDirection = value; }
    }

    // Start is called before the first frame update
    void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _camera = GetComponentInChildren<Camera>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Moves the Player
        Vector3 velocity = MoveDirection * _speed * Time.fixedDeltaTime;
        _rigidbody.MovePosition(transform.position + velocity);

        //Rotates the Player and Camera
        if (Input.GetKey(KeyCode.E)) rotDirection++;
        if (Input.GetKey(KeyCode.Q)) rotDirection--;
        Quaternion playerRotation = Quaternion.Euler(0, rotDirection * _rotationSpeed * Time.fixedDeltaTime, 0);
        _rigidbody.MoveRotation(playerRotation);

    }
}
