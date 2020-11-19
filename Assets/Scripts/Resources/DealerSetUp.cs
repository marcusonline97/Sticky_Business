using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
namespace Resources
{
    public class DealerSetUp : MonoBehaviour
    {
        public DealerData[] Datas;
        public DealerResourceProducer Prefab;

        void Start()
        {
            foreach (var ProductionUnit in this.Datas)
            {
                var instance = Instantiate(this.Prefab, this.transform);
                instance.DealerSetUp(ProductionUnit);
            }
        }
    }
}