using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class InteractHitzoneScript : MonoBehaviour {

	InventoryManagerScript playerInventory;
	List<GameObject> lootableObjects;

	// Use this for initialization
	void Start () {
		lootableObjects = new List<GameObject>();
		playerInventory = gameObject.transform.parent.GetComponent<InventoryManagerScript> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.E) && lootableObjects.Count > 0) {
			LootContainerScript lootContainerScript = lootableObjects [0].GetComponent<LootContainerScript>();
			lootContainerScript.PlayerInteract ();
			playerInventory.incrementItemCount();

			if (!lootContainerScript.hasLoot)
				RemoveLootableObject (lootableObjects [0]);
		}
	}

	void OnTriggerEnter (Collider other) {
		AddLootableObject (other.gameObject);
	}

	void OnTriggerExit (Collider other) {
		RemoveLootableObject (other.gameObject);
	}

	private void AddLootableObject(GameObject gameObject) {
		Debug.Log ("Trying to add lootable object");

		if (gameObject.GetComponent<LootContainerScript>() != null && !lootableObjects.Contains(gameObject)) {
			// TODO: Check if object is lootable (is a lootable object AND has loot)
			lootableObjects.Add(gameObject);
			Debug.Log ("Added lootable object");
			Debug.Log (gameObject.name);
		}
	}

	private void RemoveLootableObject(GameObject gameObject) {
		Debug.Log ("Trying to remove lootable object");

		if (lootableObjects.Contains(gameObject)) {
			lootableObjects.Remove(gameObject);
			Debug.Log ("Removed lootable object");
			Debug.Log (gameObject.name);
		}
	}
}
