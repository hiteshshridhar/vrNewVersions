using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTracker : MonoBehaviour
{
    public int requiredPoint;
    internal static ScoreTracker instance;
    [SerializeField] private GameObject ReloadGame;
    [SerializeField] private GameObject scoreBoard;
    [SerializeField] private LevelCompleteScript levelCompleteScript;
    public GameObject MenuBoard;
    public AudioSource audioSource;

    internal ScoreTracker() { instance = this; }

    public void PointAchieved()
    {
        Debug.Log(GameManager.instance.score);

        if (GameManager.instance.score > requiredPoint)
        {
            

            Debug.Log("You Won");
            if(ReloadGame != null) { 
            ReloadGame.SetActive(true);
            }
            scoreBoard.SetActive(false);
            MenuBoard.SetActive(true);
            levelCompleteScript.OnLevelOnCompleteFunc();
            audioSource.Stop();
        }
    }
}
