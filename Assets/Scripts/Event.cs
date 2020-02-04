using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class Event : MonoBehaviour
{
    // Start is called before the first frame update
    static public Event instance;
    public UnityEvent nextScene;
    public Animator can;
    

    private void Awake()
    {
        instance = this;
        nextScene.AddListener(gotonext);
    }

    
    IEnumerator heartmovement()
    {

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(6f);
        if (SceneManager.GetActiveScene().buildIndex == 1)
            SceneManager.LoadScene("inter1");
        else if (SceneManager.GetActiveScene().buildIndex == 3)
            SceneManager.LoadScene("inter2");
        else if (SceneManager.GetActiveScene().buildIndex == 5)
            SceneManager.LoadScene(0);
        //After we have waited 5 seconds print the time again.

    }
    public void gotonext() {
        can.SetTrigger("fadeout");
        StartCoroutine(heartmovement());
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            nextScene.Invoke();
        }

    }
}
