using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Resources
{
    [CreateAssetMenu]
    public class Resource : ScriptableObject
    {
        public Color color;
        public int AmountPerClick = 1;


        void Start()
        {
            StayAboveZero();
        }
        void Update()
        {
            StayAboveZero();
        }

        public int OwnedResource
        {
            get => PlayerPrefs.GetInt(this.name, 0);
            set => PlayerPrefs.SetInt(this.name, value);
        }

        public void Produce()
        {
            this.OwnedResource += this.AmountPerClick;
        }

        public void StayAboveZero()
        {
            if (OwnedResource < 0)
            {
                OwnedResource = 0;
            }
        }
    }
}
