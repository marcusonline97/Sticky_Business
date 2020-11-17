using Resources;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
[CreateAssetMenu(menuName = "BuyableObject", fileName = "BuyableObject")]
public class Buyable : ScriptableObject
{
    public int Price;
    public Resource Resource;
    public Resource BuyableItem;
    public bool ItemBought;

    public bool CanTradeItem
    {
        get
        {
            return Price <= Resource.OwnedResource;
        }
    }

    public void TradeResource()
    {
        if (CanTradeItem) 
        { 
            Resource.OwnedResource -= Price;
            
            BuyableItem.Produce();

            ItemBought = true;
        }

        else
        {
            ItemBought = false;

        }

    }

    
}
