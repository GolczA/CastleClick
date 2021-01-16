using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Proba : MonoBehaviour
{
    public Text damageLvl;
    int damage = 100;

    public void Update()
    {
        damageLvl.text = damage.ToString() + "/" + "20";
    }
    private void OnMouseUpAsButton()
    {
        if (gameObject.name == "DamageLvl")
        {
            damage--;
        }
         

    }
}
