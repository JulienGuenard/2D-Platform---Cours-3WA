using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Move : Camera
{
    public Transform player;

    public float speed;

    public void MoveToPlayer()
        {
        Vector3 newPos = new Vector3(player.position.x, player.position.y, -10);
        transform.position = Vector3.Lerp(transform.position, newPos, speed);
        }
}
