using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turner : MonoBehaviour
{
    private int count = 0;
    private int cd = 100;
    public Followinghearts TA;
    public MovePlan1 TB;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        cd++;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (count == 0 && cd > 100)
        {
            TA.transform.Rotate(new Vector3(0, 90, 0));
            TB.transform.Rotate(new Vector3(0, 0, 90));
            TA.tweek = 2;
            cd = 0;
            count = 1;
        }
        else if (count == 1 && cd > 100)
        {
            TA.transform.Rotate(new Vector3(0, -90, 0));
            TB.transform.Rotate(new Vector3(0, 0, -90));
            TA.tweek = 1;
            cd = 0;
            count = 0;
        }
        else
        {

        }
    }
}
