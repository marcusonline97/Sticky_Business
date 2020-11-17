using UnityEngine;

public class BuyableUI : MonoBehaviour
{
    public Buyable buyable;

    // Update is called once per frame
    void Update()
    {
        buyable.TradeResource();
    }

}
