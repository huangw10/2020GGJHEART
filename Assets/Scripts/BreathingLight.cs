using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreathingLight : MonoBehaviour
{
    public Animator light;
    // Start is called before the first frame update
    void Start()
    {
        light.SetTrigger("breathing");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
