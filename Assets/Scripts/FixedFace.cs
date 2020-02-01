using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedFace : MonoBehaviour
{
    private Transform body;
    // Start is called before the first frame update
    void Start()
    {
        body = this.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        body.rotation = Quaternion.identity;
    }
}
