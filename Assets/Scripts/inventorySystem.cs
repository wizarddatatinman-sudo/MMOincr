using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class inventorySystem : MonoBehaviour
{

	private Dictionary<itemData, int> inventory = new Dictionary<itemData, int>();
    public event Action onInventoryChanged;


    // Start is called before the first frame update
    void Start()
    {
        
    }


    public  Dictionary<itemData, int> getInventory(){

    	return inventory;

    }

    public void addItem(itemData item, int quantity){

    	if (item == null || quantity <= 0){
    		return ;
			}

    	if(inventory.ContainsKey(item)){
 			inventory[item] += quantity;
		}
		else {
			inventory.Add(item, quantity);
		}

		Debug.Log(item.itemName + " : " + inventory[item]);

		Debug.Log("Événement inventaire émis par : " + gameObject.name);
		
		onInventoryChanged?.Invoke();
    }


			public bool removeItem(itemData item, int quantity)
			{

			if(inventory.ContainsKey(item)){
 			if (getItemQuantity(item)<quantity){
 				    return false;
 			
 			} 

 			inventory[item] -= quantity; 
 			

 			if (inventory[item] == 0){
 				inventory.Remove(item);
 				
 			}
 			

 			if (item==null || quantity == 0){
 				inventory.Remove(item);
 				
 			}

			Debug.Log(item.itemName + " : " + getItemQuantity(item));
			onInventoryChanged?.Invoke(); 
			return true;
	 }
	 else {return false;}
		
	}


    public int getItemQuantity(itemData item){

    if(inventory.ContainsKey(item)){
 			 return inventory[item];
		}
		else {
			 return 0;
		}
}






}
