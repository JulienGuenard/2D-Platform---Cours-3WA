using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dwarf_Jump : Dwarf_Heritage
{
    public float force;

    bool isJumping = false;
    bool isGrounded = true;

    private void Update()
    {
        CheckGround();
        CheckJump();
    }

    public void Jump()
    {
        if (!isGrounded) return;
        if (isJumping) return;

        isJumping = true;
            isGrounded = false;
            rb.AddForce(new Vector2(0, force));
    }

    void CheckGround()
    {
        if (isGrounded) isJumping = false;
    }

    void CheckJump()
    {
        if (isJumping)
        {
            dwarf_Animation.JumpStart();
            return;
        }
        dwarf_Animation.JumpEnd();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Ground")
        {
            transform.SetParent(collision.transform);
            isGrounded = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Ground")
        {
            transform.SetParent(null);
            isGrounded = false;
        }
    }
}
