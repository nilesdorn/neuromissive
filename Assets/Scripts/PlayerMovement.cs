using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5.0f; // Adjust this value to controle the movement speed
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    
        // Increase movement speed 
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            moveSpeed *= 2.0f;
        }
        else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            moveSpeed /= 2.0f;
        }

        float moveAmountX = 0.0f;  
        float moveAmountZ = 0.0f;

        if (Input.GetKey(KeyCode.W))
        {
            moveAmountZ = moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            moveAmountZ = -moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            moveAmountX = -moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            moveAmountX = moveSpeed * Time.deltaTime;
        }

        // Move the player GameObject
        Vector3 movement = new Vector3(moveAmountX, 0, moveAmountZ);
        transform.Translate(movement);

    }
}
