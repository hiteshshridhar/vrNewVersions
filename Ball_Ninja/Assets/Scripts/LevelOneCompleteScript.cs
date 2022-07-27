using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelOneCompleteScript : MonoBehaviour
{
    public GameObject swordLeft;
    public GameObject swordRight;
    public GameObject teleportGO;
    
    public GameObject level1;
    public GameObject StartBoard;
    public GameObject ScoreBoard;

    public void OnLevelOnCompleteFunc()
    {
        swordLeft.SetActive(false);
        swordRight.SetActive(false);
        teleportGO.SetActive(true);
    }

    public void OnPlayBtnClick()
    {
        level1.SetActive(true);
        StartBoard.SetActive(false);
        ScoreBoard.SetActive(true);
        swordLeft.SetActive(true);
        swordRight.SetActive(true);
    }

    public void OnQuit()
    {
        Application.Quit();
    }
}




