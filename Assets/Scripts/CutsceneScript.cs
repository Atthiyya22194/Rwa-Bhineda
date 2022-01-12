using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class CutsceneScript : MonoBehaviour
{
    
    public VideoPlayer vid;
    public string SceneDestination;
    public string modeScene;
    // Start is called before the first frame update
    void Start()
    {
        /*Video animasi diplay disini*/
        vid.loopPointReached += CheckOver;

    }

    public void SkipVideo()
    {
        TransitionScene.ChangeScene(SceneDestination, modeScene);

    }

    void CheckOver(UnityEngine.Video.VideoPlayer vp)
    {
        TransitionScene.ChangeScene(SceneDestination, modeScene);
    }
}
