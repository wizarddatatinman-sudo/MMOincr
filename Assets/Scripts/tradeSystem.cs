using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tradeSystem : MonoBehaviour
{

	[SerializeField] private inventorySystem inventoryRef;
	[SerializeField] private goldSystem goldRef;
	[SerializeField] private itemData itemToSell;
    

    public bool sellItem(itemData item, int quantity)
	{

		if(!inventoryRef.removeItem(item,quantity)){    //si objet pas retiré on annule la vente
			Debug.Log("une vente annuley");

			return false;

		}

			int price=item.basePrice * quantity ;// sinon calcul du prix
			goldRef.changeGold(price);
			return true;

	}

public void sellTheItem()
{
    bool success = sellItem(itemToSell, 1);

    if (success)
    {
        Debug.Log("La grosse moulah grâce à " + itemToSell.itemName);
    }
}

}
