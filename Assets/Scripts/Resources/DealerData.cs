using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Resources
{
    [CreateAssetMenu(menuName = "ResourceProduction/DealerData", fileName = "DealerResourceProductionData")]
    public class DealerData : ScriptableObject
    {
        [SerializeField] DealerResourceAmount DealerCosts;
        [SerializeField] float DealerCostMultipier = 1.1f;
        public float DealerProductionTime = 10f;
        [SerializeField] DealerResourceAmount DealerProduction;
        [SerializeField] float DealerProductionMultiplier = 1.05f;
        [SerializeField] DealerResourceAmount DealerResourceUsage;
        public int DealersAmount = 0;

        public DealerResourceAmount DealerTotalCost(int DealerAmount)
        {
            var DealerResult = this.DealerCosts;
            DealerResult.DealerAmount = Mathf.RoundToInt(DealerResult.DealerAmount * Mathf.Pow(this.DealerCostMultipier, DealerAmount));
            return DealerResult;
        }

        public DealerResourceAmount DealerResourceAdd(int DealerUpgradeAmount, int DealerUnitCount)
        {
            var Dealerresult = this.DealerProduction;
            Dealerresult.DealerAmount = Mathf.RoundToInt(Dealerresult.DealerAmount * Mathf.Pow(this.DealerProductionMultiplier, DealerUpgradeAmount) * DealerUnitCount);
            return Dealerresult;
        }

        public DealerResourceAmount DealerResourceRemove(int DealerAmount)
        {
            var DealerUsageResult = this.DealerResourceUsage;
            DealerUsageResult.DealerAmount = Mathf.RoundToInt(DealerUsageResult.DealerAmount * this.DealersAmount);
            return DealerUsageResult;
        }



        /*
        UpdateProduction() if (ownedresource > cost) {produce(); usage();}
        */

    }
}