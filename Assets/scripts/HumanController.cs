using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HumanController : MonoBehaviour
{
    
    public Animator anim;
    public float moveSpeed = 10f;


    private string moveInputAxis = "Vertical";
    private string turnInputAxis = "Horizontal";
    public float rotationRate = 180;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 1f;
        anim = GetComponent<Animator>();


    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0f, 0f, moveSpeed * Input.GetAxis("Vertical") * Time.deltaTime);  
        transform.Rotate(0f, 90f * Input.GetAxis("Horizontal") * Time.deltaTime, 0f);


        if (Input.GetKey("up") || Input.GetKey("w"))
        {
            if (Input.GetKey(KeyCode.H))
            {
                anim.SetBool("isWalking", false);
                anim.SetBool("isRunning", true);
            }
            else
            {
                anim.SetBool("isRunning", false);
                anim.SetBool("isWalking", true);
            }



            //if (Input.GetKey(KeyCode.Space))
            //{
            //    anim.SetBool("isWalking", false);
            //    anim.SetBool("isJumping", true);
            //}
            //else
            //{
            //    anim.SetBool("isJumping", false);
            //    anim.SetBool("isWalking", true);
            //}
        }
       

        else if (Input.GetKey("down") || Input.GetKey("s"))
        {
            if (Input.GetKey(KeyCode.Space))
            {
                anim.SetBool("runBack", false);
                anim.SetBool("isJumping", true);
            }
            else
            {
                anim.SetBool("isJumping", false);
                anim.SetBool("runBack", true);
            }
        }
        else if (Input.GetKey("space"))
        {
            anim.SetBool("isJumping", true);
        }

        else
        {
            anim.SetBool("isWalking", false);
            anim.SetBool("runBack", false);
            anim.SetBool("isRunning", false);
            anim.SetBool("isJumping", false);
        }

    }
}




