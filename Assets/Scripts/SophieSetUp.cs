using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
namespace Resources
{
    public class SophieSetUp : MonoBehaviour
    {
        public Data[] Datas;
        public SophieRP Prefab;

        void Start()
        {
            foreach (var ProductionUnit in this.Datas)
            {
                var instance = Instantiate(this.Prefab, this.transform);
                instance.SetUp(ProductionUnit);
            }
        }
    }
}