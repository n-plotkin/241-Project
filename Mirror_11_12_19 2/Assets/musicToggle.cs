using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicToggle : MonoBehaviour
{

    public OSC osc;
    public Renderer rend;

    void Start()
    {
        OscMessage start_music = new OscMessage();
        start_music.address = "/music/on";
        osc.Send(start_music);
    }
    void onDestroy()
    {
        OscMessage start_music = new OscMessage();
        start_music.address = "/music/off";
        osc.Send(start_music);
    }
    void onApplicationQuit()
    {
        OscMessage start_music = new OscMessage();
        start_music.address = "/music/off";
        osc.Send(start_music);
    }
    void onApplicationPause()
    {
        OscMessage start_music = new OscMessage();
        start_music.address = "/music/off";
        osc.Send(start_music);
    }



    // Toggle
    bool onoff = true;
    public void Toggle()
    {
        rend = GetComponent<Renderer>();
        OscMessage music = new OscMessage();
        if (onoff)
        {
            music.address = "/music/off";
            osc.Send(music);
            onoff = false;
            rend.material.SetColor("_Color", Color.black);
        }
        else
        {
            music.address = "/music/on";
            osc.Send(music);
            onoff = true;
            rend.material.SetColor("_Color", Color.white);
        }
    }



}
