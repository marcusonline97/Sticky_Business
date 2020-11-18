using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Resources{ 
    [CreateAssetMenu(menuName = "ResourceProduction/Data", fileName = "ResourceProductionData")]
public class Data : ScriptableObject {
        [SerializeField] ResourceAmount Costs;
        [SerializeField] float CostMultipier = 1.1f;
        public float ProductionTime = 10f;
        [SerializeField] ResourceAmount Production;
        [SerializeField] float ProductionMultiplier = 1.05f;

        [SerializeField] ResourceAmount ResourceUsage;

        public ResourceAmount TotalCost(int Amount) {
            var Result = this.Costs;
            Result.Amount = Mathf.RoundToInt(Result.Amount * Mathf.Pow(this.CostMultipier, Amount));
            return Result;
        }

        public ResourceAmount ResourceAdd(int upgradeAmount, int unitCount)
        {
            var result = this.Production;
            result.Amount = Mathf.RoundToInt(result.Amount * Mathf.Pow(this.ProductionMultiplier, upgradeAmount) * unitCount);
            return result;
        }

        public ResourceAmount ResourceRemove(int Amount) {
            var UsageResult = this.ResourceUsage;
            return UsageResult;
        }
    }
}