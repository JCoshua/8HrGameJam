using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HotrigdeInputBehavior : ObjectInputBehavior
{
    override public void Update()
    {
        if (IsActiveObject)
        {
            ObjectMovement.MoveDirection = new Vector3(0, Input.GetAxisRaw("VerticalDPad"), 0).normalized;
        }
    }

    public override void OnMouseDown()
    {
        base.OnMouseDown();
    }
}
