using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endgametrigger : MonoBehaviour
{
    // Start is called before the first frame update
    bool a = true;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "endgame" && a)
            {
            Event.instance.nextScene.Invoke();
            a = false;
        }
    }
}
