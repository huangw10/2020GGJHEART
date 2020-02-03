using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turner : MonoBehaviour
{
    private int count = 0;
    public GameObject TA;
    public GameObject TB;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void OnTriggerEnter(Collider other)
    {
        if(count == 0)
        {
            TA.transform.Rotate(new Vector3(0, 90, 0));
            TB.transform.Rotate(new Vector3(0, 0, 90));
        }
        else
        {
            TA.transform.Rotate(new Vector3(0, -90, 0));
            TB.transform.Rotate(new Vector3(0, 0, -90));
        }

        if (count == 0)
        {
            count = 1;
        }
        else
        {
            count = 0;
        }
    }
}
