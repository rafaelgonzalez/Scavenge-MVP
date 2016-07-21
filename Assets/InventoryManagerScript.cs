using UnityEngine;
using System.Collections;

public class InventoryManagerScript : MonoBehaviour {

	int itemCount = 0;
	int totalItems = 0;

	public LootPanelScript lootPanelScript;

	// Use this for initialization
	void Start () {
		totalItems = countTotalLootableObjectWithLoot ();

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

	private int countTotalLootableObjectWithLoot () {
		LootContainerScript[] lootContainerScripts = Component.FindObjectsOfType<LootContainerScript> ();

		int count = 0;

		for (int i = 0; i < lootContainerScripts.Length; i++) {
			if (lootContainerScripts[i].hasLoot == true) {
				count += 1;
			}
		}

		return count;
	}
}
