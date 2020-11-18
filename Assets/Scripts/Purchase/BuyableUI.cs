using UnityEngine;
using Resources;
using UnityEngine.UI;

public class BuyableUI : MonoBehaviour
{
    public Buyable buyable;
    public HoneyBar honeybar;
    public Resource resource;

    private void Start()
    {
    }

    void Update()
    {
        buyable.TradeResource();

        honeybar.SetHoney(resource.OwnedResource);

    }

}
