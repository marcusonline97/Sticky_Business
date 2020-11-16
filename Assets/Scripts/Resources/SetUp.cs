using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
namespace Resources
{
    public class SetUp : MonoBehaviour
    {
        public Data[] Datas;
        public ResourceProducer Prefab;

        void Start()
        {
            foreach (var ProductionUnit in this.Datas) {
                var instance = Instantiate(this.Prefab, this.transform);
                instance.SetUp(ProductionUnit);
            }
        }
    }
}