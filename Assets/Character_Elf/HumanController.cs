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
        if (Input.GetKey("left"))
        {
            anim.SetBool("isRunning", true);

        }
        else if (Input.GetKey("right"))
        {
            anim.SetBool("isRunning", true);
        }
        else if (Input.GetKey("up"))
        {
            anim.SetBool("isRunning", true);
        }
        else if (Input.GetKey("down"))
        {
            anim.SetBool("runBack", true);
        }
        else { anim.SetBool("isRunning", false);
            anim.SetBool("runBack", false);
        }
        
    }
}
