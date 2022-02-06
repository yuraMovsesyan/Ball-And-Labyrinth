using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LvlManager : MonoBehaviour
{
    public static void Restart() => SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex);
    public static void Next()
    {
        if (SceneManager.GetActiveScene().buildIndex + 1 == 10)
            SceneManager.LoadSceneAsync(0);
        else
            SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
