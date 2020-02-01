using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramovement2 : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;
    private bool updateornot = true;

    [SerializeField] public float smoothSpeed;

    [SerializeField] public Vector3 Offset;

    void FixedUpdate()
    {
        if (updateornot)
         {
            Vector3 desiredPosition = target.position + Offset;
            Vector3 smoothedPosition = Vector3.Lerp(this.transform.position, desiredPosition, smoothSpeed);
            transform.position = smoothedPosition;

            transform.LookAt(target);
            transform.rotation = Quaternion.Euler(90, 0, 0);
        }
    }
}
