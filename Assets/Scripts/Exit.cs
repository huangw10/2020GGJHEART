using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    public GameObject title;



    void Start()
    {
        title.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = this.GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
        
        RaycastHit hit;

        if (title.activeSelf)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                title.SetActive(false);
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                title.SetActive(true);
            }
        }


        if (Physics.Raycast(ray, out hit))
        {
            if (hit.transform.tag == "Yes")
            {
                Debug.Log("Exit");
            }
        }
    }

    void Close()
    {
        Application.Quit();
    }
}
