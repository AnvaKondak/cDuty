using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderController : MonoBehaviour
{
    public float turn_speed;

    public Animator anim;

    public Transform target;
    const float Epsilon = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        turn_speed = 1f;

        anim = GetComponent<Animator>();
      
    }

    // Update is called once per frame
    void Update()
    {
        //transform.LookAt(target.position);
       


        if ((transform.position - target.position).magnitude > Epsilon) {
         
            transform.Translate(0.0f,0.0f,turn_speed * Time.deltaTime);
        }

    }

     

}




        
