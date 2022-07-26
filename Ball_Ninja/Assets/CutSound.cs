using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutSound : MonoBehaviour
{
    public AudioSource audioSource;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Block"))
        {
            audioSource.Play();
        }
    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.tag == "Block")
    //    {
    //        Debug.Log("hfjhkkjhjf");
    //    }
    //}
}
