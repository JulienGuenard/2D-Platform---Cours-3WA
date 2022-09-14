using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : Camera_Heritage
{
    void Update()
    {
        camera_Move.MoveToPlayer();
    }
}
