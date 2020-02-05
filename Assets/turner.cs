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

    public IEnumerator OnTriggerEnter(Collider other)
    {
        int i;
        if (count == 0 && cd > 100)
        {
            TB.controlvault = false;
            for (i = 0; i < 90; i++)
            {
                yield return new WaitForSeconds(0.01f);
                TB.movement = new Vector3(0, 0, 0);
                TA.transform.Rotate(new Vector3(0, 1, 0));
                TB.transform.Rotate(new Vector3(0, 0, 1));
            }
            TA.tweek = 2;
            cd = 0;
            count = 1;
            TB.controlvault = true;
        }
        else if (count == 1 && cd > 100)
        {
            TB.controlvault = false;
            for (i = 0; i < 90; i++)
            {
                yield return new WaitForSeconds(0.01f);
                TB.movement = new Vector3(0, 0, 0);
                TA.transform.Rotate(new Vector3(0, -1, 0));
                TB.transform.Rotate(new Vector3(0, 0, -1));
            }
            TA.tweek = 1;
            cd = 0;
            count = 0;
            TB.controlvault = true;
        }
        else
        {

        }
    }
}
