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

        public int OwnedResource
        {
            get => PlayerPrefs.GetInt(this.name, 1);
            set => PlayerPrefs.SetInt(this.name, value);
        }
        public void Produce()
        {
            this.OwnedResource += this.AmountPerClick;
        }
    }
}
