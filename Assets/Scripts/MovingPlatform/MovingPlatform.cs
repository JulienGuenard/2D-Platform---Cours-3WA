using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public float speed;
    public float delay;

    void Awake()
    {
        StartCoroutine(ChangeWay());
    }

    void Update()
    {
        Move();
    }

    void Move()
    {
        transform.position += new Vector3(speed, 0, 0) * Time.deltaTime;
    }

    IEnumerator ChangeWay()
    {
        yield return new WaitForSeconds(delay);
        speed = -speed;
        StartCoroutine(ChangeWay());
    }
}
