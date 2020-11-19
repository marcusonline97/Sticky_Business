using System;
using Resources;
using UnityEngine;
using UnityEngine.UI;

namespace Resources
{
	[Serializable]
	public class DealerPurchasable
	{
		public Text ButtonLable;
		DealerData ResourceData;
		string DealerProductId;
		private const string currentlyUsedSaveFile = "Currently Used SaveFile: ";

		public bool DealerIsPurchasable => this.ResourceData.DealerTotalCost(this.DealerAmount).DealerPurchasable;

		public bool DealerIsUsageble => this.ResourceData.DealerResourceRemove(this.DealerAmount).DealerPurchasable;

		/*
		public int Amount
		{
			get => PlayerPrefs.GetInt(this.ResourceData.name + "_" + this.ProductId + PlayerPrefs.GetString(currentlyUsedSaveFile, "default"), 0);
			private set => PlayerPrefs.SetInt(this.ResourceData.name + "_" + this.ProductId + PlayerPrefs.GetString(currentlyUsedSaveFile), value);
		}
		*/
		public int DealerAmount
		{
			get => PlayerPrefs.GetInt(PlayerPrefs.GetString(currentlyUsedSaveFile, "default") + this.ResourceData.name + "_" + this.DealerProductId, 0);
			private set => PlayerPrefs.SetInt(PlayerPrefs.GetString(currentlyUsedSaveFile, "default") + this.ResourceData.name + "_" + this.DealerProductId, value);
		}

		public void DealerSetUp(DealerData ResourceData, string DealerProductId)
		{
			this.ResourceData = ResourceData;
			this.DealerProductId = DealerProductId;
			DealerUpdateCostLabel();
		}

		public void DealerPurchase()
		{
			if (!this.DealerIsPurchasable)
				return;
			this.ResourceData.DealerTotalCost(this.DealerAmount).RemoveResource();
			this.DealerAmount += 1;
			this.ResourceData.DealersAmount += 1;
			DealerUpdateCostLabel();
		}
		void DealerUpdateCostLabel()
		{
			var updatedCosts = this.ResourceData.DealerTotalCost(this.DealerAmount);
			this.ButtonLable.text = $"Buy {this.DealerProductId} for {updatedCosts}";
		}

		public void Update() => UpdateTextColor();
		void UpdateTextColor() => this.ButtonLable.color = this.DealerIsPurchasable ? Color.black : Color.red;
	}
}
