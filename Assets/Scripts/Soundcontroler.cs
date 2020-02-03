using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soundcontroler : MonoBehaviour
{
    // Start is called before the first frame update
    private AudioSource myself;
    private bool keepFadingIn;
    private bool keepFadingOut;
    private void Awake()
    {
        myself = this.GetComponent<AudioSource>();
    }
    void Start()
    {
        Event.instance.nextScene.AddListener(fadeaway);
        myself.Play(0);
        StartCoroutine(FadeIn(0.03f, 1));
    }

    public void fadeaway()
    {
        StartCoroutine(FadeOut(0.005f));
    }

    // Update is called once per fram

    IEnumerator FadeIn(float speed, float maxVolume) {
        keepFadingIn = true;
        keepFadingOut = false;
        myself.volume = 0;
        float audioVolume = myself.volume;

        while (audioVolume < maxVolume && keepFadingIn)
        {
            audioVolume += speed;
            myself.volume = audioVolume;
            yield return new WaitForSeconds(0.1f);
        }
    }

    IEnumerator FadeOut(float speed)
    {
        keepFadingIn = false;
        keepFadingOut = true;
        
        float audioVolume = myself.volume;

        while (audioVolume >=  speed && keepFadingOut)
        {
            audioVolume -= speed;
            myself.volume = audioVolume;
            yield return new WaitForSeconds(0.1f);
        }
    }
}
