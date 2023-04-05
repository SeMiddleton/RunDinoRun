using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisionBehaviour : MonoBehaviour
{
    [SerializeField]
    private bool _isEnemy;
    [SerializeField]
    private float _scoreMultiplier = 3;    
    [SerializeField]
    private bool _deathWall;

    public float Score;
    public Transform SpawnPoint;

    // Update is called once per frame
    void Update()
    {
        if (!_isEnemy)
        {
            Score += _scoreMultiplier * Time.deltaTime;
        }
    }

    /// <summary>
    /// Checks to see if the player has collided with an enemy
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionEnter(Collision collision)
    {
        //If the enemy has collided with the player...
        if (collision.gameObject.CompareTag("Enemy"))
            //...set isEnemy to be true
            _isEnemy = true;

        //If isEnemy is true...
        if (_isEnemy == true)
        {
            //...set player active to false
            gameObject.SetActive(false);
            gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
        }        
    }
    public void Respawn()
    {            
            _isEnemy = false;
            gameObject.SetActive(true);
            transform.position = SpawnPoint.position;
    }
}