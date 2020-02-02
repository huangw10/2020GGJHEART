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
        nextScene.AddListener(gotonext);
    }

    IEnumerator heartmovement()
    {

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(6f);
        //After we have waited 5 seconds print the time again.

    }
    public void gotonext() {
        can.SetTrigger("fadeout");
    }

}
