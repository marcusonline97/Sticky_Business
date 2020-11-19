using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Resources
{
	public class DealerResourceProducer : MonoBehaviour
	{
		public DealerData DealerData;
		[FormerlySerializedAs("Resource Amount Text")] public Text titleText;
		public DealerPurchasable Dealeramount;
		public DealerPurchasable Dealerupgrade;
		float elapsedTime;

		public void DealerSetUp(DealerData Dealerdata)
		{
			this.DealerData = Dealerdata;
			this.gameObject.name = Dealerdata.name;
			this.Dealeramount.DealerSetUp(Dealerdata, $"{this.DealerData.name}");
			this.Dealerupgrade.DealerSetUp(Dealerdata, "Upgrade");

		}
		
		public void Purchase() => this.Dealeramount.DealerPurchase();
		public void Upgrade() => this.Dealerupgrade.DealerPurchase();

		void Update()
		{
			UpdateProduction();
			UpdateTitleLabel();
			this.Dealeramount.Update();
			this.Dealerupgrade.Update();
		}

		void UpdateProduction()
		{
			this.elapsedTime += Time.deltaTime;
			if (this.elapsedTime >= this.DealerData.DealerProductionTime)
			{
				Produce();
				this.elapsedTime -= this.DealerData.DealerProductionTime;
			}
		}

		void UpdateTitleLabel()
		{
			this.titleText.text = ToString();
		}

		public override string ToString()
		{
			return $"You have {this.Dealeramount.DealerAmount} {this.DealerData.name} Level {this.Dealerupgrade.DealerAmount}";
		}


		void Produce()
		{
			//if (!IsUseAble)
			//if (this.Usage.ResourceType.OwnedResource <= this.amount.Amount )
			//if (/*this.amount.Amount <= this.usage.Amount && */ this.amount.Amount <= 0)
			//if (this.Usage.UsageResourceType.OwnedResource <= this.Usage.UsageAmount)
			if (!this.Dealeramount.DealerIsUsageble || this.Dealeramount.DealerAmount == 0)
				//if(!this.amount.IsPurchasable || this.amount.Amount == 0)
				return;
			var productionAmount = this.DealerData.DealerResourceAdd(this.Dealerupgrade.DealerAmount, this.Dealeramount.DealerAmount);
			productionAmount.AddResource();

			var productionUsage = this.DealerData.DealerResourceRemove(this.Dealeramount.DealerAmount);
			productionUsage.RemoveResource();

		}
		/*
		void Usage()
		{
			if (this.amount.Amount == 0||  this.amount.Amount < this.amount.Amount)
				return;
			
			var productionUsage = this.Data.ResourceRemove(this.amount.Amount);
			productionUsage.UsageResource();
			
			var productionAmount = this.Data.ResourceAdd(this.upgrade.Amount, this.amount.Amount);
			productionAmount.AddResource();
		}
		*/
	}


}