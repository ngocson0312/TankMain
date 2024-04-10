using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class FixedJoystick : Joystick
{
    public override void OnPointerDown(PointerEventData eventData)
    {
        TankMover.pointerDown = false;
        base.OnPointerDown(eventData);
    }

    public override void OnPointerUp(PointerEventData eventData)
    {
        TankMover.pointerDown = true;
        base.OnPointerUp(eventData);
    }
}