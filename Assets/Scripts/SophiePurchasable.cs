using System;
using Resources;
using UnityEngine;
using UnityEngine.UI;

namespace Resources
{
	[Serializable]
	public class SophiePurchasable
	{
		//public Text ButtonLable;
		Data ResourceData;
		string ProductId;
		private const string currentlyUsedSaveFile = "Currently Used SaveFile: ";
		public ResourceAmount resourceamount;

		bool IsPurchasable => this.ResourceData.TotalCost(this.Amount).Purchasable;

		public int Amount
		{
			get => PlayerPrefs.GetInt(this.ResourceData.name + "_" + this.ProductId + PlayerPrefs.GetString(currentlyUsedSaveFile, "default"), 0);
			private set => PlayerPrefs.SetInt(this.ResourceData.name + "_" + this.ProductId + PlayerPrefs.GetString(currentlyUsedSaveFile), value);
		}

		public void SetUp(Data ResourceData, string ProductId)
		{
			this.ResourceData = ResourceData;
			this.ProductId = ProductId;
			//UpdateCostLabel();
		}

		public void Purchase()
		{
			if (!this.IsPurchasable)
				return;

			if (resourceamount.Amount > 0)
			{
				this.ResourceData.TotalCost(this.Amount).RemoveResource();
				this.Amount += 1;
			}
			//UpdateCostLabel();
		}

		//void UpdateCostLabel()
		//{
		//	var updatedCosts = this.ResourceData.TotalCost(this.Amount);
		//	this.ButtonLable.text = $"Buy {this.ProductId} for {updatedCosts}";
		//}

		//public void Update()/* => UpdateTextColor()*/;
		//void UpdateTextColor() => this.ButtonLable.color = this.IsPurchasable ? Color.white : Color.red;
	}
}