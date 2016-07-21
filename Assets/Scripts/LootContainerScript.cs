using UnityEngine;
using System.Collections;

[RequireComponent(typeof (Renderer))]
public class LootContainerScript : MonoBehaviour {

	public bool hasLoot = false;

	private Color lootColor = Color.yellow;
	private Color noLootColor = Color.gray;

	// Use this for initialization
	void Start () {
		UpdateLootState (hasLoot);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void UpdateLootState (bool lootState) {
		hasLoot = lootState;

		if (hasLoot == true) {
			GetComponent<Renderer>().material.color = lootColor;
		}
		else {
			GetComponent<Renderer>().material.color = noLootColor;
		}
	}

	public bool PlayerCanInteract () {
		return hasLoot;
	}

	public void PlayerInteract() {
		UpdateLootState (false);
	}
}
