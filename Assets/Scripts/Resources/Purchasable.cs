using System;
using Resources;
using UnityEngine;
using UnityEngine.UI;

namespace Resources
{
	[Serializable]
	public class Purchasable {
		public Text ButtonLable;
		Data ResourceData;
		string ProductId;

		bool IsPurchasable => this.ResourceData.TotalCost(this.Amount).Purchasable;

		public int Amount {
			get => PlayerPrefs.GetInt(this.ResourceData.name+"_"+this.ProductId, 0);
			private set => PlayerPrefs.SetInt(this.ResourceData.name+"_"+this.ProductId, value);
		}

		public void SetUp(Data ResourceData, string ProductId) {
			this.ResourceData = ResourceData;
			this.ProductId = ProductId;
			UpdateCostLabel();
		}

		public void Purchase() {
			if (!this.IsPurchasable) 
				return;
			this.ResourceData.TotalCost(this.Amount).RemoveResource();
			this.Amount += 1;
			UpdateCostLabel();
		}

		void UpdateCostLabel() {
			var updatedCosts = this.ResourceData.TotalCost(this.Amount);
			this.ButtonLable.text = $"Buy {this.ProductId} for {updatedCosts}";
		}

		public void Update() => UpdateTextColor();
		void UpdateTextColor() => this.ButtonLable.color = this.IsPurchasable ? Color.white : Color.red;
	}
}