using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Resources
{
    [System.Serializable]
    public struct DealerResourceAmount
    {
        public int DealerAmount;
        public Resource DealerResourceType;
        public override string ToString()
        {
            return $"{this.DealerAmount} {this.DealerResourceType.name}";
        }
        public bool DealerPurchasable => this.DealerResourceType.OwnedResource >= this.DealerAmount;
        public void AddResource()
        {
            this.DealerResourceType.OwnedResource += this.DealerAmount;
        }
        public void RemoveResource()
        {
            this.DealerResourceType.OwnedResource -= this.DealerAmount;
        }
        public DealerResourceAmount(int DealerAmount, Resource DealerResourceType, int DealerUsageAmount, Resource DealerUsageResourceType)
        {
            this.DealerAmount = DealerAmount;
            this.DealerResourceType = DealerResourceType;
        }

    }
}