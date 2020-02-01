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
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playernum == 0)
        {
            movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) + Vector3.up * Physics.gravity.y * Time.deltaTime * gravityCof;
        }

        if (playernum == 1)
        {
            movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) + Vector3.up * Physics.gravity.y * Time.deltaTime * gravityCof;
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

}
