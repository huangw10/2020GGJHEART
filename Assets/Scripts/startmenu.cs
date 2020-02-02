using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startmenu : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator heart;
    private GameObject botton;
    public Animator light;
    void Start()
    {
        botton = GameObject.FindGameObjectWithTag("Botton");
    }

    public void StartGame()
    {
        heart.SetTrigger("startgame");
        light.SetTrigger("startgame");
        botton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
