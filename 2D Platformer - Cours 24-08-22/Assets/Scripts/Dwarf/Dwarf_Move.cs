using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dwarf_Move : Dwarf_Heritage
{
    public float speed;

    public void Move(float x)
    {
        Vector2 newVelocity = new Vector2(x * speed, rb.velocity.y);
        rb.velocity = newVelocity;
    }
}
