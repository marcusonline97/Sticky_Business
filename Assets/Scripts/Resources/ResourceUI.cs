using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Resources
{
    public class ResourceUI : MonoBehaviour
    {
        public Text TheAmountText;
        public Text TheResourceNameText;
        public Resource resource;
        void Update()
        {
            this.TheAmountText.text = this.resource.OwnedResource.ToString();
            this.TheResourceNameText.text = this.resource.name;
            this.TheAmountText.color = this.resource.color;
            this.TheResourceNameText.color = this.resource.color;
        }
        public void SetUp(Resource resource)
        {
            this.resource = resource;
        }

        public void Produce()
        {
            this.resource.Produce();
        }
    }
}

