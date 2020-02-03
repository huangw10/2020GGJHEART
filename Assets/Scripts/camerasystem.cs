using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerasystem : MonoBehaviour
{
    static public camerasystem instance;
    public GameObject MainCamera;
    public GameObject Cam1;
    public GameObject Cam2;
  //  private bool turnoffornot; 
    private Animator a;
    [SerializeField] private float distance;
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
            if (updateornot && Vector3.Distance(Cam1.transform.position, Cam2.transform.position) < distance)
            {
                MergeCamera();
            }
            if (updateornot == false && Vector3.Distance(Cam1.transform.position, Cam2.transform.position) >= distance)
            {
                Debug.Log("split");
                SplitCamera();
            }
       // }
    }
}
