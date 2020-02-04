using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class camerasystem : MonoBehaviour
{
    static public camerasystem instance;
    public GameObject MainCamera;
    public GameObject Cam1;
    public GameObject Cam2;
  //  private bool turnoffornot; 
    private Animator a;
    private float distancex = 5f;
    private float distancez = 3f;
    private float distancenx = 3f;
    private float distanceny = 1.8f;
    public bool updateornot = true;
    // Start is called before the first frame update

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        a = this.GetComponent<Animator>();
        //     Event.instance.nextScene.AddListener(turnthisoff);
    }

    //public void turnthisoff()
  //  {
   //     turnoffornot = false;
  //  }
    public void MergeCamera()
    {
        if (updateornot)
        {
            updateornot = false;
            a.SetTrigger("change1");
        }
        
    }

    public void SplitCamera()
    {
        Debug.Log("split");
        if (updateornot == false)
        {
            Debug.Log("split");
            updateornot = true;
            a.SetTrigger("change2");
        }

    }
    // Update is called once per frame
    void Update()
    {
        // if (turnoffornot)
        // {
        if (SceneManager.GetActiveScene().buildIndex == 5)
        {
            if (updateornot && Mathf.Abs(Cam1.transform.position.x - Cam2.transform.position.x) < distancenx && Mathf.Abs(Cam1.transform.position.z - Cam2.transform.position.z) < distanceny)
            {
                MergeCamera();
            }
            if (updateornot == false && Mathf.Abs(Cam1.transform.position.x - Cam2.transform.position.x) >= distancenx || updateornot == false && Mathf.Abs(Cam1.transform.position.z - Cam2.transform.position.z) >= distanceny)
            {
                Debug.Log("split");
                SplitCamera();
            }
        }
        else
        {
            if (updateornot && Mathf.Abs(Cam1.transform.position.x - Cam2.transform.position.x) < distancex && Mathf.Abs(Cam1.transform.position.z - Cam2.transform.position.z) < distancez)
            {
                MergeCamera();
            }
            if (updateornot == false && Mathf.Abs(Cam1.transform.position.x - Cam2.transform.position.x) >= distancex || updateornot == false && Mathf.Abs(Cam1.transform.position.z - Cam2.transform.position.z) >= distancez)
            {
                Debug.Log("split");
                SplitCamera();
            }
        }
       // }
    }
}
