using UnityEngine;

public class gatherSystem : MonoBehaviour
{
    [SerializeField] private xpSystem xpRef;
    [SerializeField] private inventorySystem inventoryRef;
	[SerializeField] private itemData[] gatheredItem;


void Awake()
{
    Debug.Log("Objet : " + gameObject.name);
    Debug.Log("Nombre d'items : " + gatheredItem.Length);

    for (int i = 0; i < gatheredItem.Length; i++)
    {
        Debug.Log("Item " + i + " : " +
            (gatheredItem[i] == null ? "NULL" : gatheredItem[i].itemName));
    }
}

    public void gather(int quantity)
    {



    quantity += UnityEngine.Random.Range(0, 4);

    int randomIndex = UnityEngine.Random.Range(0, gatheredItem.Length);
    itemData selectedItem = gatheredItem[randomIndex];

    xpRef.addXp(50);
    inventoryRef.addItem(selectedItem, quantity);
    }
}