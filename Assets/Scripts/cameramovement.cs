using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramovement : MonoBehaviour
{
    public Transform target;
    public Transform anothertarget;
    [SerializeField]public float smoothSpeed;
    public Vector3 mergeposition;

    [SerializeField] public Vector3 Offset;

    private bool moveornot = true;

    private void Awake()
    {
        Event.instance.nextScene.AddListener(stopmoving);
    }

    public void stopmoving()
    {
        moveornot = false;
        mergeposition = (target.position + anothertarget.position) / 2;
    }
    void FixedUpdate()
    {
        if (moveornot)
        {
            Vector3 desiredPosition = target.position + Offset;
            Vector3 smoothedPosition = Vector3.Lerp(this.transform.position, desiredPosition, smoothSpeed);
            transform.position = smoothedPosition;

            transform.LookAt(target);
            transform.rotation = Quaternion.Euler(90, 0, 0);
        }
        else
        {
            Vector3 desiredPosition = mergeposition + Offset;
            Vector3 smoothedPosition = Vector3.Lerp(this.transform.position, desiredPosition, smoothSpeed);
            transform.position = smoothedPosition;

            transform.LookAt(target);
            transform.rotation = Quaternion.Euler(90, 0, 0);
        }
    }
}
