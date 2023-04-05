using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputBehaviour : MonoBehaviour
{
    private PlayerMovementBehaviour _moveBehaviour;
    public int PlayerNum;

    // Start is called before the first frame update
    void Start()
    {
        _moveBehaviour = GetComponent<PlayerMovementBehaviour>();
    }

    //Update is called once per frame
    void Update()
    {
        
            _moveBehaviour.SetMoveDirection(new Vector3(Input.GetAxisRaw("Horizontal"), 0, 0));
            if (Input.GetKeyDown(KeyCode.W))
                _moveBehaviour.Jump();
        
    }
}
