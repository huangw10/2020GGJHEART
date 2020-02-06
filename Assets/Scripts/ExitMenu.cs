using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitMenu : MonoBehaviour
{
    public GameObject title;
    public Material red;
    public Material blue;
    public GameObject rightYes1;
    public GameObject rightYes2;
    public GameObject rightNo1;
    public GameObject rightNo2;
    // Start is called before the first frame update
    void Start()
    {
        title.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (title.activeSelf)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                title.SetActive(false);
                Time.timeScale = 1;
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                title.SetActive(true);
                Time.timeScale = 0;
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
                rightNo1.GetComponent<Renderer>().material = red;
                rightNo2.GetComponent<Renderer>().material = red;
                if (Input.GetMouseButtonDown(0))
                {
                    title.SetActive(false);
                    Time.timeScale = 1;
                }


            }
            else
            {
                rightYes1.GetComponent<Renderer>().material = blue;
                rightYes2.GetComponent<Renderer>().material = blue;
                rightNo1.GetComponent<Renderer>().material = blue;
                rightNo2.GetComponent<Renderer>().material = blue;
            }
        }
    }

    void Close()
    {
        Debug.Log("close");
        Application.Quit();

    }
}
