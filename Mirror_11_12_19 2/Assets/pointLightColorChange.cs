using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointLightColorChange : MonoBehaviour
{

    public Light currentLight;

    //Intensity variables
    public bool changeIntensity = false;
    public float intensitySpeed = 1.0f;
    public float maxIntensity = 10.0f;
    public float intensityMultiplier = 1.0f;

    //Color variables
    public bool changeColors = false;
    public float colorSpeed = 1.0f;
    public Color startColor;
    public Color endColor;

    public OSC osc;

    float startTime;

    // Start is called before the first frame update
    void Start()
    {
        currentLight = GetComponent<Light>();
        startTime = Time.time;

       // osc.SetAddressHandler( "/light/intensity/multiplier" , changeIntensityMultiplier);
    }

    // Update is called once per frame
    void Update()
    {
        if (changeIntensity)
        {
            currentLight.intensity = Mathf.PingPong(Time.time * intensitySpeed, maxIntensity);
            //if using OSC sidechain for intensity?
            //currentLight.intensity = Mathf.PingPong(Time.time * intensitySpeed, maxIntensity) * intensityMultiplier;
        }
        if (changeColors)
        {
            float t = (Mathf.Sin(Time.time - startTime * colorSpeed));
            currentLight.color = Color.Lerp(startColor, endColor, t);
        }
    }

/*
    void changeIntensityMultiplier(OscMessage message){
        intensityMultiplier = message.GetFloat(0);
    }
    */
}
