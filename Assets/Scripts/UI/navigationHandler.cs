using UnityEngine;

public class navigationHandler : MonoBehaviour
{
    [SerializeField] private GameObject professionPanel;
    [SerializeField] private GameObject inventoryPanel;

    public void showInventory()
    {
        professionPanel.SetActive(false);
        inventoryPanel.SetActive(true);

    }

    public void showProfession()
    {
        inventoryPanel.SetActive(false);
        professionPanel.SetActive(true);
    }

    void Start()
    {
        showInventory();
    }
}