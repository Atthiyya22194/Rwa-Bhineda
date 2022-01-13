using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class CutsceneScript : MonoBehaviour
{
    
    public VideoPlayer vid;
    public string SceneDestination;
    public string modeScene;
    public static bool canSkip;
    // Start is called before the first frame update
    void Start()
    {
        /*Video animasi diplay disini*/
        vid.loopPointReached += CheckOver;
        

    }

    private void Update()
    {
        if (canSkip == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                SkipVideo();
            }
        }

        ///Utnuk bisa skip scene pada testing
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SkipVideo();
        }
        ///harap di dihapus apabila mau dipublish
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
