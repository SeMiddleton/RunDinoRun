using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundColliderBehaviour : MonoBehaviour
{
    public bool IsGrounded;

    /// <summary>
    /// Determines what happens when the enters the ground collider
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerEnter(Collider other)
    {
        //If the player is on the ground...
        if (other.CompareTag("Ground"))
        {
            //...set "IsGrounded" to be true
            IsGrounded = true;
        }
    }

    /// <summary>
    /// Determines what happens when the exits the ground collider
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerExit(Collider other)
    {
        //When the player leaves the ground...
        if (other.CompareTag("Ground"))
        {
            //...set "IsGrounded" to be false
            IsGrounded = false;
        }
    }
}