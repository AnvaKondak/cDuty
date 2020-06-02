using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HumanController : MonoBehaviour
{
    public Animator anim;
    public float moveSpeed;

   
    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 1f;
        anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
    

        transform.Translate(moveSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, moveSpeed * Input.GetAxis("Vertical") * Time.deltaTime);
        if (Input.GetKey("left") || Input.GetKey("a"))
        {
            anim.SetBool("isWalking", true);

        }
        else if (Input.GetKey("right") || Input.GetKey("d"))
        {
            anim.SetBool("isWalking", true);
        }
        else if (Input.GetKey("up") || Input.GetKey("w"))
        {
            anim.SetBool("isWalking", true);
        }
        else if (Input.GetKey("down") || Input.GetKey("s"))
        {
            anim.SetBool("runBack", true);
        }
     /*  else if (Input.GetKey("left") || Input.GetKey("j"))
        {
            anim.SetBool("isRunning", true);

        }*/
        else { anim.SetBool("isWalking", false);
            anim.SetBool("runBack", false);
            anim.SetBool("isRunning", false);
        }

       /* if ((GetButtonDown("w") && GetButton("j"))
    || (GetButtonDown("j") && GetButton("w"))
   { anim.SetBool("isRunning", true); }
   */




        }

    /*private bool GetButtonDown(string v)
    {
        throw new NotImplementedException();
    }

    private bool GetButton(string v)
    {
        throw new NotImplementedException();
    }*/
}
