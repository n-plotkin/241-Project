using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class staticColorChange : MonoBehaviour
{
    public Renderer rend;
    //Color variables
    public bool changeColors = false;
    public float colorSpeed = 1.0f;
    public Color startColor;
    public Color endColor;

    float startTime;

    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (changeColors)
        {
            float t = (Mathf.Sin(Time.time - startTime * colorSpeed));
            rend.material.SetColor("_Color", Color.Lerp(startColor, endColor, t));
        }
    }
}
