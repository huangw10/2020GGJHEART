using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hint : MonoBehaviour
{
    public Transform my_position;
    public Transform target_player;
    private Transform mp;
    // Start is called before the first frame update
    void Start()
    {
        mp = this.GetComponent<Transform>();
        this.GetComponentInChildren<ParticleSystem>().Play();
    }

    // Update is called once per frame
    void Update()
    {
        mp.position = my_position.position;


        Vector3 direction = target_player.position - my_position.position;
        Quaternion rotation = Quaternion.LookRotation(direction);
        mp.rotation = rotation;
        mp.eulerAngles = new Vector3(90, mp.eulerAngles.y, mp.eulerAngles.z + 65);

        // mp.Rotate();

    }
}
