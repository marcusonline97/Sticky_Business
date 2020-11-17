using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Resources
{
	public class ResourceProducer : MonoBehaviour
	{
		public Data Data;
		[FormerlySerializedAs("Resource Amount Text")] public Text titleText;
		public Purchasable amount;
		public Purchasable upgrade;
		float elapsedTime;

		public void SetUp(Data data)
		{
			this.Data = data;
			this.gameObject.name = data.name;
			this.amount.SetUp(data, $"{this.Data.name}");
			this.upgrade.SetUp(data, "Upgrade");
		}

		public void Purchase() => this.amount.Purchase();
		public void Upgrade() => this.upgrade.Purchase();

		void Update()
		{
			UpdateProduction();
			UpdateTitleLabel();
			this.amount.Update();
			this.upgrade.Update();
		}

		public void UpdateProduction()
		{
			this.elapsedTime += Time.deltaTime;
			
				if (this.elapsedTime >= this.Data.ProductionTime)
				{
				    Produce();
					this.elapsedTime -= this.Data.ProductionTime;
				}
			    
		}

		void UpdateTitleLabel()
		{
			this.titleText.text = ToString();
		}

		public override string ToString()
		{
			return $"{this.amount.Amount}x {this.Data.name} Level {this.upgrade.Amount}";
		}

		void Produce()
		{
			if (this.amount.Amount == 0)
				return;
			var productionAmount = this.Data.ResourceAdd(this.upgrade.Amount, this.amount.Amount);
			productionAmount.AddResource();
			
		}
	}
}