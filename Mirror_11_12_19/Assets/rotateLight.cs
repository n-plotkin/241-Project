using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateLight : MonoBehaviour
{
    public float spinForce;
    public int counter = 0;
    public Renderer rend;
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
            rend.material.SetColor("_Color", Color.red);

        } else
        {
            spinForce = 0;
            rend = GetComponent<Renderer>();
            rend.material.SetColor("_Color", Color.white);
        }
        
    }
}
