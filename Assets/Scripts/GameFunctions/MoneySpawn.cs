using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MoneySpawn : MonoBehaviour
{
    Rigidbody2D rb;
    float YForce = 10;
    public float Speed;
    public bool hasFaded;
    Image img;
    float time;
    public float maxtime;
    public float fadetime;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        img = GetComponent<Image>();
        img.canvasRenderer.SetAlpha(1.0f);

    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(0, YForce * Speed);
        FadeOut();

        if (hasFaded)
        {
            time += Time.deltaTime;
            if (time >= maxtime)
            {
                hasFaded = false;
                time = 0;
                Destroy(gameObject);
            }
        }

    }

    void FadeOut()
    {
        img.CrossFadeAlpha(0, fadetime, false);
        hasFaded = true;
    }
}
