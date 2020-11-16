using Resources;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BuyableUI : MonoBehaviour
{
    public Image Door;
    Color[] colors = { Color.white, Color.grey };

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
            Door.color = colors[0];
        }
        else
        {
            Door.color = colors[1];

        }
    }
}
