using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public Transform CameraTarget;
    public float pLerp = .01f;
    public float rLerp = .02f;

    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, CameraTarget.position, pLerp);
        transform.rotation = Quaternion.Lerp(transform.rotation, CameraTarget.rotation, rLerp);
    }
}
