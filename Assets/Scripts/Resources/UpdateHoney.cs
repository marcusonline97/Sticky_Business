using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Resources
{
    public class UpdateHoney : MonoBehaviour
    {
        public SetUp ResourceProducer;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            ResourceProducer.Prefab.UpdateProduction();

        }
    }
}