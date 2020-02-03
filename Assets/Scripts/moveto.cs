using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveto : MonoBehaviour
{
    private float t = 0;
    Vector3 startPosition;
    Vector3 target;
    public Vector3 distance;
    public float timeToReachTarget = 4f;
    public Vector3 Difference;
    public GameObject Cam1;
    private bool move = false;
    private SphereCollider f;
    void Start()
    {
        f = this.GetComponent<SphereCollider>();
        Event.instance.nextScene.AddListener(starttomove);
    }
    void starttomove() {
        move = true;
        startPosition = this.transform.position;
        target = Cam1.transform.position + distance;
        Difference = target - startPosition;
        f.enabled = false;

    }
    void Update()
    {
        if (move)
        {
            t += Time.deltaTime / timeToReachTarget;
            transform.position = startPosition + Difference * t;
        }
    }
    
}
