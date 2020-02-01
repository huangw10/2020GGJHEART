using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerasystem : MonoBehaviour
{
    static public camerasystem instance;
    public GameObject Cam1;
    public GameObject Cam2;
    private Animator a;
    public bool updateornot = true;
    // Start is called before the first frame update

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        a = this.GetComponent<Animator>();
        a.SetBool("change", false);
    }

    public void MergeCamera()
    {
        updateornot = false;
        a.SetBool("change", true);
    }
    // Update is called once per frame
    void Update()
    {
        Debug.Log(Vector3.Distance(Cam1.transform.position, Cam2.transform.position));
        if ( Vector3.Distance(Cam1.transform.position, Cam2.transform.position) < 5)
        {
            MergeCamera();
        }
    }
}
