﻿using System.Collections;
using UnityEngine;

public class ControllerState2D
{
    public bool IsCollidingRight { get; set; }
    public bool IsCollidingLeft { get; set; }
    public bool IsCollidingAbove { get; set; }
    public bool IsCollidingBelow { get; set; }
    public bool IsMovingDownSlope { get; set; }
    public bool IsMovingUpSlope { get; set; }
    public bool IsGrounded { get { return IsCollidingBelow; } }
    public float SlopeAngle { get; set; }
    public bool HasCollisions { get { return IsCollidingAbove || IsCollidingBelow || IsCollidingLeft || IsCollidingRight; } }

    public void Reset()
    {
        IsCollidingRight = IsCollidingLeft = IsCollidingAbove = IsCollidingBelow = IsMovingDownSlope = IsMovingUpSlope = false;

        SlopeAngle = 0;
    }

    public override string ToString()
    {
        return string.Format("(controller: r:{0} l:{1} a:{2} b:{3} down-slope{4} up-slope:{5} angle:{6})",
            IsCollidingRight, IsCollidingLeft, IsCollidingAbove, IsCollidingBelow, IsMovingDownSlope, IsMovingUpSlope, SlopeAngle);
    }
}
