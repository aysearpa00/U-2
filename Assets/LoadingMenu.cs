using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingMenu : MonoBehaviour
{
    public void LoadingScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
