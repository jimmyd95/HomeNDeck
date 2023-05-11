using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicalMenuManager : MonoBehaviour
{

    [SerializeField] private GameObject _menu;
    [SerializeField] private GameObject _SummoningSpot;

    private bool menuOut = false;

    // set the physical menu to avaliable and not over summon it
    // it would be funny if I get to summon multiple of it... but then it won't be useful
    public void SetMenu()
    {
        Debug.Log("I see it being activated");
        if (!menuOut)
        {
            menuOut = true;
            Instantiate(_menu, _SummoningSpot.transform.position, Quaternion.identity);
            Debug.Log("The Menu has been summoned");
        }
        else
        {
            menuOut = false;
            Debug.Log("Destroyed the menu");
            if (_menu)
                Destroy(_menu);
        }
    }

}
