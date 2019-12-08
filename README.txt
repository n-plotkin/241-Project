To run:

Open the folder 'Mirror_11_12_19 2' in Unity.

OSC IP address and ports need to be set correctly in Unity project before building. You can find these under the inspector for the object named "OSC"

OSC IP address and ports need to be set correctly in Max_OSC_Stuff/241_final_music.maxpat. There is a red panel that contains OSC objects.


Max 'udprecieve' port needs to match the "Out Port" parameter of the "OSC" object in Unity.
Max 'udpsend' port needs to match the "In Port" parameter of the "OSC" object.
Max 'udpsend' IP needs to match the IP of the device (probably a phone) that is running the Unity project.

Unity "OSC" object's "Out IP" parameter needs to match the IP of the device that is running the max patch.
 

You can send the sound via bluetooth to the phone playing running the Unity project (or maybe some headphones) for some extra immersion, if you want to.

Max_OSC_Stuff/241_final_music.maxpat needs to be running while the unity program is running.

Have fun! 

