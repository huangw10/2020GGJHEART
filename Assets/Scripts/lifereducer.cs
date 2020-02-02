using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lifereducer : MonoBehaviour
{
    public List<airwall> reduceit;
    private int count = 0;

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
        for (count = 0; count < 2; count++)
        {
            reduceit[count].reducelife();
        }
    }
}
