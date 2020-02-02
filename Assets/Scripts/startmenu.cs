using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        StartCoroutine(ExampleCoroutine());
    }

    IEnumerator ExampleCoroutine()
    {

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene("level_0");
        //After we have waited 5 seconds print the time again.
        
    }

    // Update is called once per frame
    
}
