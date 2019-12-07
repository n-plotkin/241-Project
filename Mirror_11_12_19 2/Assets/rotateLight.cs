using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateLight : MonoBehaviour
{
    public float spinForce;
    public int counter = 0;
    public Renderer rend;
    public OSC osc;


    IList<Color> colors = new List<Color>() { Color.blue, Color.green, Color.yellow, Color.magenta, Color.cyan, Color.red, Color.black };
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, spinForce * Time.deltaTime, 0);
    }

    public void changeSpin()
    {
        counter++;
        if (counter%2==0)
        {
            spinForce = 45;
            rend = GetComponent<Renderer>();
            rend.material.SetColor("_Color", colors[counter%7]);
            
            //turns on music siren
            OscMessage siren_on = new OscMessage();
            siren_on.address = "/cube/rotation/on";
            osc.Send(siren_on);



        } else
        {
            spinForce = 0;
            rend = GetComponent<Renderer>();
            rend.material.SetColor("_Color", colors[counter % 7]);

            //turns off music siren
            OscMessage siren_off = new OscMessage();
            siren_off.address = "/cube/rotation/off";
            osc.Send(siren_off);
        }
        
    }
}
