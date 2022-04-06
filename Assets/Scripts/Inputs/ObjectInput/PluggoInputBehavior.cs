using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PluggoInputBehavior : ObjectInputBehavior
{
    override public void Update()
    {
        if (IsActiveObject)
        {
            Vector3 forwardMovement = gameObject.transform.forward * Input.GetAxisRaw("VerticalDPad");
            Vector3 horiznotalMovement = gameObject.transform.right * Input.GetAxisRaw("HorizontalDPad");
            ObjectMovement.MoveDirection = (forwardMovement + horiznotalMovement).normalized;
        }
    }

    public override void OnMouseDown()
    {
        base.OnMouseDown();
        ObjectMovement.ObjectRigidbody.isKinematic = false;
        ObjectMovement.ObjectRigidbody.useGravity = true;
    }
}
