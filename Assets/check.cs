using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class check : MonoBehaviour
{
    public List<Airwall> downdown;
    public GameObject light;

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
        downdown[0].life -= 1;
        print("checked");
        Destroy(light);
        Destroy(this);
    }
}
