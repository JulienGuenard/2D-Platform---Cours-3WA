using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingChandelier : MonoBehaviour
{
    public float speed;
    public float delay;

    Rigidbody2D rb;
    HingeJoint2D hinge;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        hinge = GetComponent<HingeJoint2D>();
        StartCoroutine(ChangeWay());
    }

    void Update()
    {
        Move();
    }

    void Move()
    {
        JointMotor2D motor = hinge.motor;
        motor.motorSpeed = speed;
        hinge.motor = motor;
    }

    IEnumerator ChangeWay()
    {
        yield return new WaitForSeconds(delay);
        speed = -speed;
        StartCoroutine(ChangeWay());
    }
}
