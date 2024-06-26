using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class AppManager : MonoBehaviour
{

    public void DoRestart()
    {

        print("Restarting");
        SceneManager.LoadScene("MainMenu");

    }

    public void DoQuit()
    {
#if (UNITY_EDITOR)
        UnityEditor.EditorApplication.isPlaying = false;
#elif (UNITY_WEBGL)
        Application.OpenURL("https://web.papunet.net/pelit/");
#elif (UNITY_STANDALONE)
        Application.Quit();
#endif
    }
    public void Taso1()
    {
        SceneManager.LoadScene("Taso1");
    }

    public void Taso2()
    {
        SceneManager.LoadScene("Taso2");
    }

    public void Taso3()
    {
        SceneManager.LoadScene("Taso3");
    }

    public void DoPlayMusic()
    {
        GameObject.FindGameObjectWithTag("Music").GetComponent<MusicPlayer>().PlayMusic();
    }

    public void DoStopMusic()
    {
        GameObject.FindGameObjectWithTag("Music").GetComponent<MusicPlayer>().StopMusic();
    }

    public void RemoveInstance()
    {
        MusicPlayer.instance.RemoveThis();
    }
}
