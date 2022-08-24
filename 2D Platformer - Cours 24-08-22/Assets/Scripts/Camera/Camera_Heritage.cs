using UnityEngine;

public class Camera_Heritage : MonoBehaviour
{
    [HideInInspector] public Camera_Move camera_Move;

    void Awake()
    {
        camera_Move = GetComponent<Camera_Move>();
    }
}
