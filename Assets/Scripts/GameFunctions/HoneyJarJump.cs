using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoneyJarJump : MonoBehaviour
{
    public float LaunchForce;
    public float HalfPoint;
    public float Speed;
    public float Offset;

    public GameObject Money;
    Rigidbody2D rb;

    public float XForce;
    float YForce;

    GameObject Target;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        Target = GameObject.FindGameObjectWithTag("SellButton");
        Launch();
    }
    void Update()
    {
        Launch();
        RemoveObject();
    }

    void Launch()
    {
        if (rb.position.x < HalfPoint)
        {

            Mathf.Pow(YForce, Speed);

            YForce += Speed;

        }
        else
        {
            Mathf.Pow(YForce, Speed);

            YForce -= Speed;

        }
        rb.velocity = new Vector2(XForce * LaunchForce, YForce);

    }
    void RemoveObject()
    {
        if (transform.position.x >= Target.transform.position.x - Offset)
        {
            GameObject money = Instantiate(Money);
            money.transform.SetParent(GameObject.FindGameObjectWithTag("SellButton").transform, false);
            Destroy(gameObject);
        }

    }

}
