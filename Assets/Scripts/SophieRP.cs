using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Resources
{
	public class SophieRP : MonoBehaviour
	{
		public Data Data;
		//[FormerlySerializedAs("Resource Amount Text")] public Text titleText;
		public SophiePurchasable amount;
		public SophiePurchasable upgrade;
		public SophiePurchasable usage;

		public ResourceAmount resource;
		float elapsedTime;

		public void SetUp(Data data)
		{
			this.Data = data;
			this.gameObject.name = data.name;
			this.amount.SetUp(data, $"{this.Data.name}");
			this.upgrade.SetUp(data, "Upgrade");
			this.usage.SetUp(data, "Usage");
		}

		public void Purchase() => this.amount.Purchase();
		public void Upgrade() => this.upgrade.Purchase();

		public void Useble() => this.usage.Purchase();

		void Update()
		{
			UpdateProduction();
			Debug.Log(resource.Amount);
		}

		void UpdateProduction()
		{
			this.elapsedTime += Time.deltaTime;
			if (this.elapsedTime >= this.Data.ProductionTime)
			{
				Produce();
				Usage();
				this.elapsedTime -= this.Data.ProductionTime;
			}
		}

		void Produce()
		{
			if (this.amount.Amount == 0)
				return;
			var productionAmount = this.Data.ResourceAdd(this.upgrade.Amount, this.amount.Amount);
			productionAmount.AddResource();

		}
		void Usage()
		{
			if (this.amount.Amount == 0)
				return;
			var productionUsage = this.Data.ResourceRemove(this.amount.Amount);
			productionUsage.RemoveResource();
		}
	}
}