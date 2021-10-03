using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public CharacterController characterController;
    public float playerSpeed = 6.9f;

    //gravity
    Vector3 velocity;
    public float gravity = -9.81f;
    public float JumpHeight = 3f;
    public Transform groundCheck;
    public float groundDistance = 0.4f;

    public LayerMask groundMask;

    bool isGrounded;

    //Animations
    Animator animator;
    public string Walk_Animation = "isWalking";




    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //checkGround
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        if(isGrounded && velocity.y < 0){
            
            velocity.y = -2f;
        }
        //input for movement
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * y;

        if(move != Vector3.zero){
            characterController.Move(move * playerSpeed * Time.deltaTime);
            walk();
        }else{
            idle();
        }

        //jump
        if(Input.GetButtonDown("Jump") && isGrounded){
             
            velocity.y = Mathf.Sqrt(JumpHeight * -2f * gravity);
           // Jumping();

        }

        //apply gravity;
        velocity.y += gravity * Time.deltaTime;
        characterController.Move(velocity * Time.deltaTime);
    }
    public void walk(){
       animator.SetFloat("Speed", 1f);
    }

    public void idle(){
       animator.SetFloat("Speed", 0f);
    }
/* 
    public void Jumping(){
        animator.SetFloat("Speed", 1f);
        
    } */
}
