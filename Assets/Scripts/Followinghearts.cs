using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Followinghearts : MonoBehaviour
{
    public Transform targetPosition;
    public float obj_num;
    private bool turn = true;
    // Start is called before the first frame update
    void Start()
    {
        Event.instance.nextScene.AddListener(turnoffthis);
    }

    void turnoffthis()
    {
        turn = false;
    }
    // Update is called once per frame
    void Update()
    {
        if (turn)
        {
            if (obj_num == 0)
            {
                this.transform.position = targetPosition.position + new Vector3(0.44f, 0, 0);
            }
            else if (obj_num == 1)
            {
                this.transform.position = targetPosition.position + new Vector3(-0.18f, 0, 0);
            }
            else
            {
                this.transform.position = targetPosition.position;
            }

        }
    }

    public void turnthisway()
    {
        this.transform.Rotate(new Vector3(0, 90, 0));
    }

    public void turnthatway()
    {
        this.transform.Rotate(new Vector3(0, -90, 0));
    }
    
}
