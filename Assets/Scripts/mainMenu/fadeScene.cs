using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fadeScene : MonoBehaviour
{
    public float fadeSpeed;
    public bool fadeIn;
    public SpriteRenderer video;
    // Start is called before the first frame update
    void Start()
    {
        video.color = new Color(1f, 1f, 1f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        float Fade = 0f;
        if (fadeIn)
        {
            video.color = new Color(1f, 1f, 1f, Fade = +.1f);
        }
    }
}
