using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpawnHoneyhive : MonoBehaviour
{

    public Buyable Honeyhive;
    public GameObject HoneyCopy;
    public float time;
    float maxtime = 0.01f; 

    void Update()
    {
        if (Honeyhive.ItemBought)
        {
            time += Time.deltaTime;

            if (time > maxtime)
            {
                HoneyHiveActivated();
                Honeyhive.ItemBought = false;
                time = 0;
            }

        }
    }

    void HoneyHiveActivated()
    {

        GameObject hh = Instantiate(HoneyCopy);
        hh.transform.SetParent(GameObject.FindGameObjectWithTag("Beehives").transform, false);
        //hh.transform.position = new Vector2(hh.transform.position.x * 2, 0);
        Debug.Log(hh.transform.position.x);
        
    }
}
