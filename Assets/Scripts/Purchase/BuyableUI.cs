using Resources;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BuyableUI : MonoBehaviour
{
    public Buyable buyable;

    // Update is called once per frame
    void Update()
    {
        buyable.TradeResource();
    }

}
