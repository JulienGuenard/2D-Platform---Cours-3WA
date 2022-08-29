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
            animator.SetBool("isJumping", true);
        //  animator.SetBool("isFalling", false);
      //   animator.SetBool("isJumping", false);
       //    animator.SetBool("isFalling", true);
    }

    public void JumpEnd()
    {
        animator.SetBool("isJumping", false);
    }

    public void FallStart()
    {
        animator.SetBool("isFalling", true);
        animator.SetBool("isJumping", false);
    }

    public void FallEnd()
    {
        animator.SetBool("isFalling", false);
        animator.SetBool("isJumping", false);
    }

    public void VictoryStart()
    {
        animator.SetBool("isVictory", !animator.GetBool("isVictory"));
    }

    public void AttackStart()
    {
        animator.SetBool("isAttacking", true);
    }

    public void AttackEnd()
    {
        animator.SetBool("isAttacking", false);
    }
}
