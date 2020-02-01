using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerasystem : MonoBehaviour
{
    static public camerasystem instance;
    public GameObject MainCamera;
    public GameObject Cam1;
    public GameObject Cam2;
    private Animator a;
    [SerializeField] float distance;
    public bool updateornot = true;
    // Start is called before the first frame update

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        a = this.GetComponent<Animator>();
    }

    public void MergeCamera()
    {
        if (updateornot)
        {
            updateornot = false;
            a.SetTrigger("change1");
            MainCamera.transform.rotation = Cam1.transform.rotation;
            MainCamera.transform.position = Cam1.transform.position;
        }
        
    }
    // Update is called once per frame
    void Update()
    {
        Debug.Log(Vector3.Distance(Cam1.transform.position, Cam2.transform.position));
        if ( Vector3.Distance(Cam1.transform.position, Cam2.transform.position) < distance)
        {
            MergeCamera();
        }
    }
}
