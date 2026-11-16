using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class inventoryHandler : MonoBehaviour
{


	[SerializeField] private inventorySlotHandler inventorySlotPrefab;
	[SerializeField] private Transform inventoryContent;
	[SerializeField] private inventorySystem inventoryRef;
  
void Start()
{
    refreshInventory();
}

    void refreshInventory()
{


Debug.Log("Refresh inventaire déclenché !");
Debug.Log("Types d'objets : " + inventoryRef.getInventory().Count);

 foreach (Transform child in inventoryContent)
    {
		    child.gameObject.SetActive(false);
    		Destroy(child.gameObject);
    }

    foreach (var entry in inventoryRef.getInventory())
    {

        inventorySlotHandler newSlot =
            Instantiate(inventorySlotPrefab, inventoryContent);

        newSlot.updateSlot(entry.Key, entry.Value);
    }
}

  		void OnEnable()
    	{
    	Debug.Log("Abonnement inventaire sur : " + inventoryRef.gameObject.name);
		inventoryRef.onInventoryChanged += refreshInventory;
		    refreshInventory();

    	}

		void OnDisable()
    	{
    		inventoryRef.onInventoryChanged -= refreshInventory;
    	}



}
