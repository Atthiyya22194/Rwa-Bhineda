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
    public string StateVideo;
    // Start is called before the first frame update
    void Start()
    {
        /*Video animasi diplay disini*/
        if (StateVideo == "Cutscene")
        {
            vid.loopPointReached += CheckOver;
        }
        
        

    }

    private void Update()
    {
        if (StateVideo == "Cutscene")
        {
            if (canSkip == true)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    SkipVideo();
                }
            }
            
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SkipVideo();
        }

        ///Utnuk bisa skip scene pada testing

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
