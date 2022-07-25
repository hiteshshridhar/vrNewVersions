using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTracker : MonoBehaviour
{
    public int requiredPoint;
    internal static ScoreTracker instance;
    [SerializeField] private GameObject gameStatusBoard;
    [SerializeField] private GameObject scoreBoard;
    [SerializeField] private LevelOneCompleteScript levelOneCompleteScript;

    internal ScoreTracker() { instance = this; }

    public void PointAchieved()
    {
        if(GameManager.instance.score > requiredPoint)
        {
            Debug.Log("You Won");
            gameStatusBoard.SetActive(true);
            scoreBoard.SetActive(false);
            levelOneCompleteScript.OnLevelOnCompleteFunc();
        }
    }
}
