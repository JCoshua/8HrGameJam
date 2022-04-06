using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInputBehavior : MonoBehaviour
{
    private ObjectMovementBehavior _objectMovement;
    private bool _isActiveObject = false;
    [SerializeField]
    private GameObject _controller;

    public ObjectMovementBehavior ObjectMovement
    {
        get {return _objectMovement;}
    }

    public bool IsActiveObject
    {
        get { return _isActiveObject; }
        set { _isActiveObject = true; }
    }


    // Start is called before the first frame update
    void Awake()
    {
        _objectMovement = GetComponent<ObjectMovementBehavior>();
    }

    // Update is called once per frame
    public virtual void Update()
    {

    }

    public virtual void OnMouseDown()
    {
        if(_isActiveObject == true)
        {
            _isActiveObject = false;
            return;
        }

        _isActiveObject = true;
        GameObject currentActiveObject = _controller.GetComponent<PlayerInputBehavior>().ActiveObject;
        if(currentActiveObject != null)
        {
            currentActiveObject.GetComponent<ObjectInputBehavior>().IsActiveObject = false;
        }

        _controller.GetComponent<PlayerInputBehavior>().ActiveObject = gameObject;
    }
}
