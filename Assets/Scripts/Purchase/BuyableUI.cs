using Resources;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BuyableUI : MonoBehaviour
{
    public Text BuyableText;
    Color[] colors = { Color.black, Color.red };

    public Buyable buyable;

    // Update is called once per frame
    void Update()
    {
        UpdateColors();
    }
    void UpdateColors()
    {
        if (buyable.CanBuyItem)
        {
            BuyableText.color = colors[0];
        }
        else
        {
            BuyableText.color = colors[1];

        }
    }
}
