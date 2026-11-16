using UnityEngine;

[CreateAssetMenu(fileName = "NewItem", menuName = "MMOincr/Item")]
public class itemData : ScriptableObject
{
    public string itemName;
    public int basePrice;
    public Sprite icon;
}