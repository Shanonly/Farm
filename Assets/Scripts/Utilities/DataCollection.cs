using UnityEngine;

[System.Serializable]
public class ItemDetails
{
    // Start is called before the first frame update
    public int itemID;
    public string itemName;

    public Sprite itemIcon;

    public ItemType itemType;

    public Sprite itemOnWorldSprite;

    public string itemDescription;

    public int itemUseRadius;

    public bool canPickedup;

    public bool canDropped;

    public bool canCarried;

    public int itemPrice;
    [Range(0,1)]
    public float sellPercentage;
}
