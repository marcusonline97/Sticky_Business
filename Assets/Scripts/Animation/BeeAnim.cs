using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeeAnim : MonoBehaviour
{
    Rigidbody2D rb;
    float timer = 1;
    float secondtimer = 2;
    float leftWalkTimer;
    float rightWalkTimer;
    float standstillTimer;

    public bool WalkingRight;
    public bool WalkingLeft;
    public bool StandingStill;


    public float speed;
    void Awake()
    {
        standstillTimer = timer;
        rightWalkTimer = secondtimer;
        leftWalkTimer = secondtimer;
    }
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }


    void Update()
    {

        EnemyWalking();
        Debug.Log(transform.position);
    }

    void EnemyWalking()
    {
        float chosen_xdir = Random.Range(2, 5);
        float chosen_ydir = Random.Range(1, 3);

        rb.position = new Vector2(chosen_xdir * speed, chosen_ydir * speed);

        //if (transform.position.x > (1301 - 500) && transform.position.x < (1301 + 500))
        //    {
        //        rb.velocity = new Vector2(chosen_xdir * speed, chosen_ydir * speed);
        //    }
        //    else
        //    {
        //        rb.velocity = new Vector2((chosen_xdir * speed) * -1, (chosen_ydir * speed) * -1);
        //    }
   
    
    }

 }

