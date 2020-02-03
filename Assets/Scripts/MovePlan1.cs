using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlan1 : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3 movement;
    public float speed = 5f;
    public float gravityCof = 9.8f;
    public float playernum = 0;
    private bool setcontrol = true;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        Event.instance.nextScene.AddListener(turnoffcontrol);
    }


    public void turnoffcontrol()
    { setcontrol = false; }
    // Update is called once per frame
    void Update()
    {
        if (setcontrol)
        {
            if (playernum == 0)
            {
                movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) + Vector3.up * Physics.gravity.y * Time.deltaTime * gravityCof;
            }

            if (playernum == 1)
            {
                movement = new Vector3(Input.GetAxis("Horizontal1"), 0, Input.GetAxis("Vertical1")) + Vector3.up * Physics.gravity.y * Time.deltaTime * gravityCof;
            }
        }

    }

    void FixedUpdate()
    {
        Move(movement);
    }

    void Move(Vector3 mm)
    {
        rb.velocity = mm * speed;
    }

    public void turnthisway()
    {
            this.transform.Rotate(new Vector3(0, 90, 0));
    }

    public void turnthatway()
    {
            this.transform.Rotate(new Vector3(0, -90, 0));
    }

}
