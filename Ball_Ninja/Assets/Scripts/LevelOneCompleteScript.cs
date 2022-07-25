using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelOneCompleteScript : MonoBehaviour
{
    public GameObject swordLeft;
    public GameObject swordRight;
    public GameObject teleportGO;
    
    public Track track;

    public void OnLevelOnCompleteFunc()
    {
        swordLeft.SetActive(false);
        swordRight.SetActive(false);
        teleportGO.SetActive(true);
    }

    public void OnTeleport()
    {
        GameManager.instance.leftSwordTracker = swordLeft.GetComponent<VelocityTracker>();
        GameManager.instance.rightSwordTracker = swordRight.GetComponent<VelocityTracker>();
        teleportGO.SetActive(false);
        swordLeft.SetActive(true);
        swordRight.SetActive(true);
        //SceneManager.LoadScene(1);
        
    }
}




