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
    float maxtime = .3f;
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
                Destroy(this);
                hasFaded = false;
                time = 0;
            }
        }

    }

    void FadeOut()
    {
        img.CrossFadeAlpha(0, 1, false);
        hasFaded = true;
    }
}
