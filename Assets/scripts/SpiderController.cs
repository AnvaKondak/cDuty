using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderController : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    public HealthbarScript healthBar;

    public Animator anim;

    public Transform target;
   

    // Start is called before the first frame update
    void Start()
    {

        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);


        anim = GetComponent<Animator>();
      
    }

    // Update is called once per frame
    void Update()   
    {   Vector3 direction = target.position - this.transform.position;
        //the float angle is resposible for the area where the spider can see
        //the player that will start the chasing.↓↓
        float angle = Vector3.Angle(direction, this.transform.forward);

        if (Vector3.Distance(target.position, transform.position) < 7 && angle < 30)
        {
            
            this.transform.rotation = Quaternion.Slerp(this.transform.rotation,
                                     Quaternion.LookRotation(direction), 0.1f);

            direction.y = 0;
            anim.SetBool("isIdle", false);

            if (direction.magnitude > 2)
            {
                this.transform.Translate(0, 0, 0.05f);
                anim.SetBool("isRunning", true);
                anim.SetBool("isAttacking", false);
            }
            else
            {
                anim.SetBool("isRunning", false);
                anim.SetBool("isAttacking", true);
            }

        }
        else { anim.SetBool("isIdle", true);
            anim.SetBool("isRunning", false);
            anim.SetBool("isAttacking", false);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(20);
        }

        void TakeDamage(int damage)
        {
            currentHealth -= damage;
            healthBar.SetHealth(currentHealth);
        }






    }

     

}




        
