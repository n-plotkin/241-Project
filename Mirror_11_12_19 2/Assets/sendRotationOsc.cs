using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sendRotationOsc : MonoBehaviour
{

    private int frameNum; //makes it so we only send messages
    public OSC osc;
    private Vector3 eulerAngles;
    // Start is called before the first frame update
    void Start()
    {
        frameNum = 0;
        OscMessage start_music = new OscMessage();
        start_music.address = "/music/on";
        osc.Send(start_music);
    }

    private void sendAngles(){
        eulerAngles = transform.eulerAngles;
        OscMessage rot = new OscMessage();
        rot.address = "/mainCamera/rotation";
        rot.values.Add(eulerAngles.x);
        rot.values.Add(eulerAngles.y);
        //mainCamera.transform.eulerAngles
        osc.Send(rot);
    }

    // Update is called once per frame
    void Update()
    {
        if(frameNum++ % 3 == 0) sendAngles();
    }
}