using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CactusController : MonoBehaviour
{

    public Animator anim;

    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = target.position - this.transform.position;
        //the float angle is resposible for the area where the spider can see
        //the player that will start the chasing.↓↓
        float angle = Vector3.Angle(direction, this.transform.forward);

        if (Vector3.Distance(target.position, transform.position) < 5 && angle < 30)
        {

            this.transform.rotation = Quaternion.Slerp(this.transform.rotation,
                                     Quaternion.LookRotation(direction), 0.1f);

            direction.y = 0;
            anim.SetBool("isIdle", false);

            if (direction.magnitude > 2)
            {
                this.transform.Translate(0, 0, 0.05f);
                anim.SetBool("isWalking", true);
                anim.SetBool("isAttacking", false);
            }
            else
            {
                anim.SetBool("isWalking", false);
                anim.SetBool("isAttacking", true);
            }

        }
        else
        {
            anim.SetBool("isIdle", true);
            anim.SetBool("isWalking", false);
            anim.SetBool("isAttacking", false);
        }
    }
}
