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

    public bool CanBuyItem
    {
        get
        {
            return Price <= Resource.OwnedResource;
        }
    }

    public void BuyHoneyJar()
    {
        if (CanBuyItem) 
        { 
        Resource.OwnedResource -= Price;

            BuyableItem.Produce();
        }
       
    }

    
}
