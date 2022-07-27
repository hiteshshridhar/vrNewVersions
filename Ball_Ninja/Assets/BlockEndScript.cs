using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockEndScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("LastBlock"))
        {
            ScoreTracker.instance.PointAchieved();
        }
    }
}
