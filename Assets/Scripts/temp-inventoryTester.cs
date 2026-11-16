using UnityEngine;

public class inventoryTester : MonoBehaviour
{
    [SerializeField] private inventorySystem inventoryRef;
    [SerializeField] private tradeSystem tradeRef;
    [SerializeField] private goldSystem goldRef;
    [SerializeField] private itemData testItem;

    void Start()
    {
        inventoryRef.addItem(testItem, 5);
        inventoryRef.addItem(testItem, 3);

        Debug.Log("Retrait 3 : " + tradeRef.sellItem(testItem, 3));
        Debug.Log("Retrait 8 : " + tradeRef.sellItem(testItem, 8));
        Debug.Log("Retrait 5 : " + tradeRef.sellItem(testItem, 5));

        Debug.Log("Stock final : " + inventoryRef.getItemQuantity(testItem));
        Debug.Log("Pesos finaux : " + goldRef.getCurrentGold());
    }
}