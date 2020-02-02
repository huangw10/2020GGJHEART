using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowingLight : MonoBehaviour
{
    public Transform targetPosition;
    public float light_num;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (light_num == 0)
        {
            this.transform.position = targetPosition.position;
        }
        else
        {
            this.transform.position = targetPosition.position + new Vector3(-0, 0, 0);
        }

    }
}
