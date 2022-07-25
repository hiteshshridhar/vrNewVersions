using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float startTime = 3.0f;
    public int score = 0;
    public float lifeTime = 1.0f;
    public int hitBlockScore = 10;
    public float missBlockLife = 0.1f;
    public float wrongBlockLife = 0.08f;
    public float lifeRegenRate = 0.1f;
    public float swordHitVelocityThreshold = 0.5f;

    public VelocityTracker leftSwordTracker;
    public VelocityTracker rightSwordTracker;

    // creating a singleton instance
    public static GameManager instance;

    void Awake()
    {
        instance = this;
    }

    // called when we hit the correct block
    public void AddScore()
    {
        score += hitBlockScore;
        GameUI.instance.UpdateScoreText();
    }

    // called when the block goes past the player
    public void MissBlock()
    {
        lifeTime -= missBlockLife;
    }

    // called when we hit the wrong block
    public void HitWrongBlock()
    {
        lifeTime -= wrongBlockLife;
    }

    void Update()
    {
        // increase lifetime over time

        //lifeTime = Mathf.MoveTowards(lifeTime, 1.0f, lifeRegenRate * Time.deltaTime);

        if (lifeTime <= 0.0f)
            LoseGame();

        
        GameUI.instance.UpdateLifetimeBar(); // update the lifetime bar
    }

    // called when the song is over
    public void LoadLevel2Game()
    {
        SceneManager.LoadScene(1);
    }

    // called when the lifetime hits 0
    public void LoseGame()
    {
        //Add a UI button to restart the game
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void RestartGame()
    {
        //Add a UI button to restart the game
        SceneManager.LoadScene(0);
    }
}


/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float startTime = 3.0f;
    public int score = 0;
    public float lifeTime = 1.0f;
    public int hitBlockScore = 10;
    public float missBlockLife = 0.1f;
    public float wrongBlockLife = 0.08f;
    public float lifeRegenRate = 0.1f;
    public float swordHitVelocityThreshold = 0.5f;

    public VelocityTracker leftSwordTracker;
    public VelocityTracker rightSwordTracker;

    // instance
    public static GameManager instance;

    void Awake()
    {
        instance = this;
    }

    // called when we hit the correct block
    public void AddScore()
    {
        score += hitBlockScore;
        GameUI.instance.UpdateScoreText();
    }

    // called when the block goes past the player
    public void MissBlock()
    {
        lifeTime -= missBlockLife;
    }

    // called when we hit the wrong block
    public void HitWrongBlock()
    {
        lifeTime -= wrongBlockLife;
    }

    void Update()
    {
        // increase lifetime over time
        lifeTime = Mathf.MoveTowards(lifeTime, 1.0f, lifeRegenRate * Time.deltaTime);

        if (lifeTime <= 0.0f)
            LoseGame();

        // update the lifetime bar
        GameUI.instance.UpdateLifetimeBar();
    }

    // called when the song is over
    public void WinGame()
    {
        SceneManager.LoadScene(0);
    }

    // called when the lifetime hits 0
    public void LoseGame()
    {
        SceneManager.LoadScene(0);
    }
}*/