using UnityEngine;
using System.Collections;

public class InventoryManagerScript : MonoBehaviour {

	int itemCount = 0;
	public int totalItems = 0;

	public LootPanelScript lootPanelScript;

	// Use this for initialization
	void Start () {
		lootPanelScript.setLootedQuantity(itemCount);
		lootPanelScript.setMaxLootableQuantity(totalItems);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void incrementItemCount() {
		itemCount += 1;

		lootPanelScript.setLootedQuantity (itemCount);
	}
}
