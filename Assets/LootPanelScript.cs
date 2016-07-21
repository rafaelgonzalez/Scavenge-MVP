using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LootPanelScript : MonoBehaviour {

	int lootedQuantity = 0;
	int maxLootableQuantity = 0;

	public Text lootedItemsQuantityText;
	public Slider lootSlider;

	// Use this for initialization
	void Start () {
		lootSlider.minValue = 0;
		lootSlider.maxValue = 0;
		lootSlider.value = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void setMaxLootableQuantity(int quantity) {
		maxLootableQuantity = quantity;
		lootSlider.maxValue = quantity;
		updateItemsQuantitiesText ();
	}

	public void setLootedQuantity (int quantity) {
		lootedQuantity = quantity;
		lootSlider.value = quantity;
		updateItemsQuantitiesText ();
	}

	private void updateItemsQuantitiesText () {
		lootedItemsQuantityText.text = lootedQuantity + " / " + maxLootableQuantity;
	}
}
