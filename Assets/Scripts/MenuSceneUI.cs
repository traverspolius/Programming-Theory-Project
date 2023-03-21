using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
//using TMPro;

public class MenuSceneUI : MonoBehaviour
{
    public static MenuSceneUI menuScene;
    public static MemoryMatchPlayer mmplayer;

    private void Awake()
    {
        if (menuScene == null)
        {
            menuScene = this;
            //DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void StartNewGame()
    {
        mmplayer = new MemoryMatchPlayer();
        mmplayer.Name = "Bob";
        Debug.Log(mmplayer.GetPlayerInfo());
        SceneManager.LoadScene(1);
        
    }
}
