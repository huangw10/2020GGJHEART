using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turner : MonoBehaviour
{
    private int count = 0;
    public List<GameObject> things;

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
        for (int i = 0; i < 2; i++)
        {
            if(count == 0)
            {
                things[i].transform.Rotate(new Vector3(0, 90, 0));
            }
            else
            {
                things[i].transform.Rotate(new Vector3(0, -90, 0));
            }
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
