using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatablockerInputComponent : ObjectInputBehavior
{

    //The Max distance on any axis that the object can move
    [SerializeField]
    private float _maxMovementRange = 0.0f;
    private float _currentDistance = 0.0f;
    private bool _shouldGoForward = true;
    public override void Update()
    {
        if (!IsActiveObject)
        {
            if (_shouldGoForward)
            {
                ObjectMovement.MoveDirection = transform.forward;
                _currentDistance += transform.forward.magnitude;
            }
            else if(!_shouldGoForward)
            {
                ObjectMovement.MoveDirection = -transform.forward;
                _currentDistance -= transform.forward.magnitude;
            }

            if(_currentDistance >= _maxMovementRange)
            {
                _shouldGoForward = false;
            }
            else if(_currentDistance <= 0)
            {
                _shouldGoForward = true;
            }
        }
        else
        {
            ObjectMovement.MoveDirection = Vector3.zero;
        }
    }
    public override void OnMouseDown()
    {
        base.OnMouseDown();
    }
}
