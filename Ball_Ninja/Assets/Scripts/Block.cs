//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public enum BlockColor
//{
//    Green,
//    Red
//}
//public class Block : MonoBehaviour
//{
//    // Start is called before the first frame update
//    public BlockColor color;

//    public GameObject brokenBlockLeft;
//    public GameObject brokenBlockRight;


//    public float brokenBlockForce;
//    public float brokenBlockTorque;
//    public float brokenBlockDestroyDelay;

//    void OnTriggerEnter(Collider other)
//    {
//        if (other.CompareTag("SwordRed"))
//        {
//            // are we a red block?
//            if (color == BlockColor.Red )
            
//            {
//                GameManager.instance.AddScore();   
//            }
//            else
//            {
//                GameManager.instance.HitWrongBlock();
//            }
//            Hit();
//        }

//        else if (other.CompareTag("SwordGreen"))
//        {
//            if (color == BlockColor.Green && GameManager.instance.leftSwordTracker.velocity.magnitude >= GameManager.instance.swordHitVelocityThreshold)
            
//            {
//                GameManager.instance.AddScore();
//            }
//            else
//            {
//                GameManager.instance.HitWrongBlock();
//            }
//            Hit();
//        }
//    }

//    public void Hit()
//    {
//        // enable the broken pieces
//        brokenBlockLeft.SetActive(true);
//        brokenBlockRight.SetActive(true);

//        //remove them as children 
//        brokenBlockLeft.transform.parent = null;
//        brokenBlockRight.transform.parent = null;

//        //adding force to the broken blocks
//        Rigidbody leftRig = brokenBlockLeft.GetComponent<Rigidbody>();
//        Rigidbody rightRig = brokenBlockRight.GetComponent<Rigidbody>();

//        leftRig.AddForce(-transform.right * brokenBlockForce, ForceMode.Impulse);
//        rightRig.AddForce(transform.right * brokenBlockForce, ForceMode.Impulse);

//        //adding torque to blocks

//        leftRig.AddTorque(-transform.forward * brokenBlockTorque, ForceMode.Impulse);
//        rightRig.AddTorque(transform.forward * brokenBlockTorque, ForceMode.Impulse);

//        //destroy the broken pieces after a time
//        Destroy(brokenBlockLeft, brokenBlockDestroyDelay);
//        Destroy(brokenBlockRight, brokenBlockDestroyDelay);

//        // Invoke("SeperateBlock", 1.0f);
//        Destroy(gameObject);

//    }

//    public void SeperateBlock()
//    {
//        //Destroy main block
//        Destroy(gameObject);
//    }

//}



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BlockColor
{
    Green,
    Red
}

public class Block : MonoBehaviour
{
    public BlockColor color;

    public GameObject brokenBlockLeft;
    public GameObject brokenBlockRight;
    public float brokenBlockForce;
    public float brokenBlockTorque;
    public float brokenBlockDestroyDelay;

    void OnTriggerEnter(Collider other)
    {
        // did the red sword hit us?
        if (other.CompareTag("SwordRed"))
        {
            // are we a red block?
            if (color == BlockColor.Red && GameManager.instance.rightSwordTracker.velocity.magnitude >= GameManager.instance.swordHitVelocityThreshold)
            {
                GameManager.instance.AddScore();
            }
            else
            {
                GameManager.instance.HitWrongBlock();
            }

            Hit();
        }
        // did the green sword hit us?
        else if (other.CompareTag("SwordGreen"))
        {
            // are we a green block?
            if (color == BlockColor.Green && GameManager.instance.leftSwordTracker.velocity.magnitude >= GameManager.instance.swordHitVelocityThreshold)
            {
                GameManager.instance.AddScore();
            }
            else
            {
                GameManager.instance.HitWrongBlock();
            }

            Hit();
        }
    }

    // called when we hit the block
    public void Hit()
    {
        // enable the broken pieces
        brokenBlockLeft.SetActive(true);
        brokenBlockRight.SetActive(true);

        // remove them as children
        brokenBlockLeft.transform.parent = null;
        brokenBlockRight.transform.parent = null;

        // add force to them
        Rigidbody leftRig = brokenBlockLeft.GetComponent<Rigidbody>();
        Rigidbody rightRig = brokenBlockRight.GetComponent<Rigidbody>();

        leftRig.AddForce(-transform.right * brokenBlockForce, ForceMode.Impulse);
        rightRig.AddForce(transform.right * brokenBlockForce, ForceMode.Impulse);

        // add torque to them
        leftRig.AddTorque(-transform.forward * brokenBlockTorque, ForceMode.Impulse);
        rightRig.AddTorque(transform.forward * brokenBlockTorque, ForceMode.Impulse);

        // destroy the broken pieces after a few seconds
        Destroy(brokenBlockLeft, brokenBlockDestroyDelay);
        Destroy(brokenBlockRight, brokenBlockDestroyDelay);

        // destroy the main block
        Destroy(gameObject);
    }
}