using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Resources
{
    public class ResourceUISetup : MonoBehaviour
    {
        public Resource[] resources;
        public ResourceUI prefab;
        void Start()
        {
            foreach (var Resource in this.resources)
            {
                var instance = Instantiate(this.prefab, this.transform);
                instance.SetUp(Resource);
            }
        }
    }
}
