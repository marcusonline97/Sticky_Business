using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Resources{
    [System.Serializable]
    public struct ResourceAmount {
        public int Amount;
        public Resource ResourceType;

        public override string ToString()
        {
            return $"{this.Amount} {this.ResourceType.name}";
        }
        public bool Purchasable => this.ResourceType.OwnedResource >= this.Amount;
        public void AddResource() 
        {
            this.ResourceType.OwnedResource += this.Amount;
        }
        public void RemoveResource()
        {
            this.ResourceType.OwnedResource -= this.Amount;
        }

        public ResourceAmount(int Amount, Resource ResourceType, int UsageAmount, Resource UsageResourceType) {
            this.Amount = Amount;
            this.ResourceType = ResourceType;
        }

    }
}