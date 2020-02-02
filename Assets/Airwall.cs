using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Airwall : MonoBehaviour
{
    public int life = 12;
    public GameObject self;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (life == 0)
        {
            GameObject.Destroy(self);
        }
    }

    public void downlife()
    {
        life -= 1;
    }
}
