using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ScoreTrackerLevel2 : MonoBehaviour
{
    public int requiredPoint;
    internal static ScoreTrackerLevel2 instance;
    [SerializeField] private GameObject gameStatusBoard;
    [SerializeField] private GameObject scoreBoard;
    [SerializeField] private LevelTwoCompleteScript levelTwoCompleteScript;
    //public GameObject MenuBoard;

    internal ScoreTrackerLevel2() { instance = this; }

    public void PointAchieved()
    {
        if (GameManager.instance.score >= requiredPoint)
        {
            Debug.Log("You Won");
            gameStatusBoard.SetActive(true);
            scoreBoard.SetActive(false);
            //MenuBoard.SetActive(true);
            levelTwoCompleteScript.OnLevelTwoCompleteFunc();
        }
    }
}
