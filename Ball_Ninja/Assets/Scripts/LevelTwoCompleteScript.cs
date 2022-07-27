using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelTwoCompleteScript : MonoBehaviour
{
    public GameObject swordLeft;
    public GameObject swordRight;
    //public GameObject teleportGO;

    public GameObject level2;
    public GameObject StartBoard;
    public GameObject ScoreBoard;

    public void OnLevelTwoCompleteFunc()
    {
        swordLeft.SetActive(false);
        swordRight.SetActive(false);
        level2.SetActive(true);
    }

    public void GameOverButton()
    {
        level2.SetActive(false);
        StartBoard.SetActive(true);
        ScoreBoard.SetActive(false);
        swordLeft.SetActive(false);
        swordRight.SetActive(false);
    }

    public void OnPlayButton()
    {
        level2.SetActive(true);
        StartBoard.SetActive(false);
        ScoreBoard.SetActive(true);
        swordLeft.SetActive(true);
        swordRight.SetActive(true);
    }
}




