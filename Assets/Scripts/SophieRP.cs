using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Resources
{
	public class SophieRP : MonoBehaviour
	{
		////	public Data Data;
		////	//[FormerlySerializedAs("Resource Amount Text")] public Text titleText;
		////	public SophiePurchasable amount;
		////	public SophiePurchasable upgrade;
		////	public SophiePurchasable usage;
		////	float elapsedTime;

		////	public void SetUp(Data data)
		////	{
		////		this.Data = data;
		////		this.gameObject.name = data.name;
		////		this.amount.SetUp(data, $"{this.Data.name}");
		////		this.upgrade.SetUp(data, "Upgrade");
		////		this.usage.SetUp(data, "Usage");
		////	}

		////	public void Purchase() => this.amount.Purchase();
		////	public void Upgrade() => this.upgrade.Purchase();

		////	public void Useble() => this.usage.Purchase();

		////	void Update()
		////	{
		////		UpdateProduction();
		////		//UpdateTitleLabel();
		////		//this.amount.Update();
		////		//this.upgrade.Update();
		////		//this.usage.Update();
		////	}

		////	void UpdateProduction()
		////	{
		////		this.elapsedTime += Time.deltaTime;
		////		if (this.elapsedTime >= this.Data.ProductionTime)
		////		{
		////			Produce();
		////			Usage();
		////			this.elapsedTime -= this.Data.ProductionTime;
		////		}
		////	}

		////	//void UpdateTitleLabel()
		////	//{
		////	//	this.titleText.text = ToString();
		////	//}

		////	//public override string ToString()
		////	//{
		////	//	return $"You have {this.amount.Amount} {this.Data.name} Level {this.upgrade.Amount}";
		////	//}

		////	void Produce()
		////	{
		////		if (this.amount.Amount == 0)
		////			return;
		////		var productionAmount = this.Data.ResourceAdd(this.upgrade.Amount, this.amount.Amount);
		////		productionAmount.AddResource();

		////	}
		////	void Usage()
		////	{
		////		if (this.amount.Amount == 0)
		////			return;
		////		var productionUsage = this.Data.ResourceRemove(this.amount.Amount);
		////		productionUsage.RemoveResource();
		////	}
		////}
	}
}