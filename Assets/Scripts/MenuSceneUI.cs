using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
//using TMPro;

public class MenuSceneUI : MonoBehaviour
{
    public static MenuSceneUI menuScene;

    private void Awake()
    {
        if (menuScene == null)
        {
            menuScene = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void StartNewGame()
    {
        SceneManager.LoadScene(1);
    }
}
