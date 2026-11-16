using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;
using UnityEngine.UI;

public class inventorySlotHandler : MonoBehaviour
{


	[SerializeField] private Image itemIcon;
	[SerializeField] private TMP_Text itemQuantityText;




    // Start is called before the first frame update
    void Start()
    {

        
    }
	public void updateSlot(itemData item,int itemQuantity){

	itemQuantityText.text = itemQuantity.ToString();
	itemIcon.sprite = item.icon;

	} 


}
