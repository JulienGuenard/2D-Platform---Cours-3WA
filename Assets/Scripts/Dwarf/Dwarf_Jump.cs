using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dwarf_Jump : Dwarf_Heritage
{
    public float force;

    bool isJumping = false;
    bool isGrounded = true;
    bool isFailling = false;

    Vector3 startPos;

    public List<GameObject> lifeList;
    int lifeCount;

    private new void Awake()
    {
        startPos = transform.position;
        lifeCount = lifeList.Count;
    }

    private void Update()
    {
        CheckGround();
        CheckFall();
    }

    public void Jump()
    {
        if (!isGrounded) return;
        if (isJumping) return;

        isJumping = true;
        isGrounded = false;
        dwarf_Animation.JumpStart();
    }

    public void JumpAfterAnimation()
    {
        rb.gravityScale = 2f;
        rb.AddForce(new Vector2(0, force));
    }

    void CheckGround()
    {
        if (isGrounded) isJumping = false;
    }

    void CheckFall()
    {
        if (rb.velocity.y < -5f)
        {
            isFailling = true;
            rb.gravityScale = 6f;
            dwarf_Animation.FallStart();
        }
        else if(isFailling)
        {
            isFailling = false;
            dwarf_Animation.FallEnd();
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Ground")
        {
            transform.SetParent(collision.transform);
            isGrounded = true;
        }

        if (collision.tag == "FallTrigger")
        {
            transform.position = startPos;
            lifeCount--;
            lifeList[lifeCount].SetActive(false);
            if (lifeCount <= 0)
            {
                GameManager.instance.Lose();
                Destroy(this.gameObject);
            }
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
