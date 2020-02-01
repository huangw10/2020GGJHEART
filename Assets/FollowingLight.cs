using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowingLight : MonoBehaviour
{
    public Transform targetPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = targetPosition.position + new Vector3(0.294f, 0.294f, 0.333f);
    }
}
