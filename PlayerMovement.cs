using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    public float speed;
    public Rigidbody2D playerRigidbody;
    private Vector2 movement;
    public Animator playerAnimator;
    
    // Update is called once per frame
    void Update()
    {
        //Inputs will be processed here
       
        
    }

    void FixedUpdate()
    {
        /*Movement will be here, because the Update() runs once per frame. 
        FixedUpdate can run once, zero, or several times per frame, 
        depending on how many physics frames per second are set in the time settings, and how fast/slow the framerate is.
        That will enable the game to run smoothly on different computers, at different framerates */
        


    }

    void ProcessInputs()
    {
        //todo

    }

    void PlayerMove()
    {
        //todo
    }




}