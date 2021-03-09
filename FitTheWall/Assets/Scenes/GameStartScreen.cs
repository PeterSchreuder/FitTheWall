using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStartScreen : MonoBehaviour
{
    void startGame()
    {
         loadGameScene();
    }

    void loadGameScene()
    {
         SceneManager.LoadScene(/*scenename van game scene*/);
         print("hello");
    }

}
