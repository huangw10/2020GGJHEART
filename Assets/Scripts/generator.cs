using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generator : MonoBehaviour
{
    public Transform wheretogenerate;
    public GameObject whattogenerate;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "player")
        {
            Instantiate(whattogenerate, wheretogenerate.position, wheretogenerate.rotation);
            GameObject.Destroy(this.gameObject);
        }
    }
}
