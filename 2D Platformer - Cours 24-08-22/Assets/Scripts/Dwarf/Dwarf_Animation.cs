using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dwarf_Animation : Dwarf_Heritage
{
    public void MoveStart(float inputX)
        {
            if (inputX != 0) animator.SetBool("isMoving", true);
            if (inputX == 0) animator.SetBool("isMoving", false);
            if (inputX > 0) transform.rotation = Quaternion.Euler(0, 0, 0);
            if (inputX < 0) transform.rotation = Quaternion.Euler(0, 180, 0);
        }

    public void JumpStart()
    {
            if (rb.velocity.y > 1) animator.SetBool("isJumping", true);
            if (rb.velocity.y > 1) animator.SetBool("isFalling", false);
            if (rb.velocity.y < 1) animator.SetBool("isJumping", false);
            if (rb.velocity.y < 1) animator.SetBool("isFalling", true);
    }

    public void JumpEnd()
    {
        animator.SetBool("isFalling", false);
        animator.SetBool("isJumping", false);
    }

    public void VictoryStart()
    {
        animator.SetBool("isVictory", !animator.GetBool("isVictory"));
    }
}
