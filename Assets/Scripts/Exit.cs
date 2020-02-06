using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    public GameObject title;
    public Material red;
    public Material blue;
    public GameObject rightYes1;
    public GameObject rightYes2;
    public float camera_num = 0;

    void Start()
    {
        title.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (UImanager.instance.isOpen)
        {
            title.SetActive(true);
        }
        else
        {
            title.SetActive(false);
        }




        if (camera_num == 0)
        {
            if (title.activeSelf)
            {
                if (Input.GetKeyDown(KeyCode.Escape))
                {
                    UImanager.instance.isOpen = false;
                    Time.timeScale = 1;
                }
            }
            else
            {
                if (Input.GetKeyDown(KeyCode.Escape))
                {
                    Time.timeScale = 0;
                    UImanager.instance.isOpen = true;
                }
            }
        }

        Ray ray = this.GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
        
        RaycastHit hit;
    
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.transform.tag == "Yes")
            {
                rightYes1.GetComponent<Renderer>().material = red;
                rightYes2.GetComponent<Renderer>().material = red;
                if (Input.GetMouseButtonDown(0))
                    Close();
            }

            else if (hit.transform.tag == "No")
            {
                rightYes1.GetComponent<Renderer>().material = red;
                rightYes2.GetComponent<Renderer>().material = red;
                if (Input.GetMouseButtonDown(0))
                {
                    UImanager.instance.isOpen = false;
                    Time.timeScale = 1;
                }
                    
            }
            else
            {
                rightYes1.GetComponent<Renderer>().material = blue;
                rightYes2.GetComponent<Renderer>().material = blue;
            }
        }
    }

    void Close()
    {
        Debug.Log("close");
        Application.Quit();
    }
}
