using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GAMEOVERMENU : MonoBehaviour
{
    // ON CLICK OF GAME OVER, TAKE US OUTSIDE THE SCENARIO

    public void GameOver() {
        Application.Quit();
    }
    public void GoToLevel1(){
        SceneManager.LoadScene(0);
    }

    public void RestartGame(){
        SceneManager.LoadScene(1);
    }


}