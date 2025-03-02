using UnityEngine;

[System.Serializable]
public class ItemDetails
{
    // Start is called before the first frame update
    public string itemID;
    public string name;

    public Sprite itemIcon;

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
