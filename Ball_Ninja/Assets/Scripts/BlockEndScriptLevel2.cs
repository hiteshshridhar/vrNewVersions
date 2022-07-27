using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockEndScriptLevel2 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("LastBlock"))
        {
            ScoreTrackerLevel2.instance.PointAchieved();
        }
    }
}
