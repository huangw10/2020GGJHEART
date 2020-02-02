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
    public string scenename;
    void Start()
    {
        botton = GameObject.FindGameObjectWithTag("Botton");
    }

    public void StartGame()
    {
        this.GetComponent<AudioSource>().Play();
        heart.SetTrigger("startgame");
        light.SetTrigger("startgame");
        botton.SetActive(false);
        StartCoroutine(ExampleCoroutine());
    }

    IEnumerator ExampleCoroutine()
    {

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene(scenename);
        //After we have waited 5 seconds print the time again.
        
    }

    // Update is called once per frame
    
}
