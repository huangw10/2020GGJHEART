using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveto : MonoBehaviour
{
    
    
    public float timeToReachTarget = 4f;
    public GameObject Cam1;
    public Vector3 smalladjestment;
    void Start()
    {
        Event.instance.nextScene.AddListener(starttomove);
    }
    void starttomove() {
        StartCoroutine(MoveToPosition(this.transform, Cam1.transform.position + smalladjestment, timeToReachTarget));
        

    }

    public IEnumerator MoveToPosition(Transform transform, Vector3 position, float timeToMove)
    {
        var currentPos = transform.position;
        var t = 0f;
        while (t < 1)
        {
            t += Time.deltaTime / timeToMove;
            transform.position = Vector3.Lerp(currentPos, position, t);
            yield return null;
        }
    }
    
}
