using UnityEngine;
using System.Collections;

[RequireComponent(typeof (Renderer))]
public class LootContainerScript : MonoBehaviour {

	public bool hasLoot = false;

	private Color lootColor = Color.yellow;
	private Color noLootColor = Color.gray;

	// Use this for initialization
	void Start () {
		if (hasLoot == true) {
			GetComponent<Renderer>().material.color = Color.yellow;
		}
		else {
			GetComponent<Renderer>().material.color = Color.grey;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
