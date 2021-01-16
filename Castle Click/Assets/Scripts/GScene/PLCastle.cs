using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PLCastle : MonoBehaviour
{
    public GameObject lose;
    
    GameObject[] bulForDell; 
    public static float plLife;
    private void Start()
    {
        plLife = 10; 
    }
    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.name == "EnemyBull(Clone)")
        {
            plLife = plLife - EnemyData.ED[0];
            Destroy(coll.gameObject);
            if (plLife <=0 && EnemyData.check == false)
            {
                lose.SetActive(true);
                Debug.Log("Замок врага" + EnemyData.ED[1].ToString() + "Замок игрока" + PLCastle.plLife.ToString());
                bulForDell = GameObject.FindGameObjectsWithTag("Bull");
                foreach (GameObject gf in bulForDell)
                {
                    Destroy(gf, 0.01f);
                }
                EnemyData.check = true;
            }
        }
    }


}
