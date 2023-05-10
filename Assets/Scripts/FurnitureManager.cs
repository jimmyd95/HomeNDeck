using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FurnitureManager : MonoBehaviour
{
    [SerializeField] private TMP_Text furnitureName;
    [SerializeField] private List<GameObject> furniture; // list of furnitures to instantiate
    [SerializeField] private GameObject summoningSpot; // the transform position of the instant

    [SerializeField] private GameObject trashCan;

    private int furnitureNum = 0; // when clicking left and right, you choose the furniture items
    private bool summonTrashCan = false; // set a bool so I can summon and destroy the trashcan

    private void Update()
    {
        furnitureName.text = furniture[furnitureNum].name;
    }

    public void SetFurniture()
    {
        Instantiate(furniture[furnitureNum], summoningSpot.transform.position, Quaternion.identity);
    }

    public void DestroyFurniture(Collider other)
    {
        if (other.CompareTag("Item"))
        {
            Destroy(other.gameObject);
        }
    }

    public void MinusNumber()
    {
        if (furnitureNum > 0)
            furnitureNum -= 1;
    }
    
    public void PlusNumber()
    {
        if (furnitureNum < furniture.Count)
            furnitureNum += 1;
    }

    public void SummonTrashCan()
    {
        if (summonTrashCan)
        {
            Instantiate(trashCan, summoningSpot.transform.position, Quaternion.identity);
        }
        else
        {
            Destroy(trashCan);
        }
    }

    private void OnDestroy()
    {
        foreach (var item in furniture)
        {
            if (item)
                Destroy(item);
        }
    }
}
