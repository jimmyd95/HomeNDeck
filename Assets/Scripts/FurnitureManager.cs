using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FurnitureManager : MonoBehaviour
{
    [SerializeField] private List<GameObject> furniture;
    [SerializeField] private Vector3 summoningSpot;

    public void SetFurniture(int index)
    {
        Instantiate(furniture[index], summoningSpot, Quaternion.identity);
    }

    public void DestroyFurniture(Collider other)
    {
        if (other.CompareTag("Item"))
        {
            Destroy(other.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        
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
