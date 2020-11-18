using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyActivated : MonoBehaviour
{
    public Buyable buyable;
    public GameObject Money;
    public float time;

    // Start is called before the first frame update
    void Start()
    {
        buyable.ItemBought = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (buyable.ItemBought)
        {
            MoneyHasSpawned();
            time += Time.deltaTime;
            if (time > 0.01)
            {
                buyable.ItemBought = false;
                time = 0;
            }
        }
       
    }

    void MoneyHasSpawned()
    {
            GameObject money = Instantiate(Money);
            money.transform.SetParent(GameObject.FindGameObjectWithTag("SellButton").transform, false);
    }
}
