using UnityEngine;

namespace Resources
{

    [CreateAssetMenu]
    public class Resource : ScriptableObject
    {
        private const string currentlyUsedSaveFile = "Currently Used SaveFile: ";
        public Color color;
        public int AmountPerClick = 1;

        public int OwnedResource
        {
            get => PlayerPrefs.GetInt(PlayerPrefs.GetString(currentlyUsedSaveFile) + this.name, 0);
            set => PlayerPrefs.SetInt(PlayerPrefs.GetString(currentlyUsedSaveFile) + this.name, value);
        }
        public void Produce()
        {
            this.OwnedResource += this.AmountPerClick;
        }
    }
}
