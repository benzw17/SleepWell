using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video; 

public class VideoLoadScript : MonoBehaviour
{

    public VideoPlayer videoPlayer; 

    // Start is called before the first frame update
    void Start()
    {
        videoPlayer.url = "file://C:/Users/vande/Unity Hub/Unity Projects/VR Sleep Well/Assets/Assets/Imported Assets/360 VR Ocean Island - Audio Begin.mp4";
        videoPlayer.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
