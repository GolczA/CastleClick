using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CompBull : MonoBehaviour
{
    // замок сразу ставим 2 го уровня , что бы были открыты все пушки 
    public GameObject enemygun1; // пушка игрока №1
    public GameObject enemygun2; // пушка игрока №2
    Vector3 eg1, eg2;
    public GameObject enemyBull; // префаб мяча противника
    public GameObject win;
    

    GameObject[] bulForDell; // сбор ядер и их удаление после победы или поражения

    //public float castleLife;// жизнь вражеского замка
    void Start()
    {
        bool check = false;
        //castleLife = EnemyData.ED[1];
        eg1 = enemygun1.transform.position;
        eg2 = enemygun2.transform.position;
        StartCoroutine(ComputerBull());
    }


    // обрабатываем выстрелы через определенный интервал время
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "PlayerBull(Clone)")
        {
            EnemyData.ED[1] = EnemyData.ED[1] - EnemyData.plDamage;
            Destroy(collision.gameObject);
            if (EnemyData.ED[1] <= 0 && EnemyData.check == false)
            {
                win.SetActive(true);
                Debug.Log("Замок врага" + EnemyData.ED[1].ToString() + "Замок игрока" + PLCastle.plLife.ToString());
                bulForDell = GameObject.FindGameObjectsWithTag("Bull");
                foreach (GameObject gr in bulForDell)
                {
                    Destroy(gr);
                }
                EnemyData.levelUp++;
                Debug.Log(EnemyData.levelUp.ToString());
                EnemyData.MLev(EnemyData.levelUp);
                EnemyData.Save();
                EnemyData.check = true;

            }
        }
    }
    IEnumerator ComputerBull()
    {
        int c = 0;
        while (EnemyData.check == false)
        {            
            Instantiate(enemyBull, eg1, Quaternion.identity);
            Instantiate(enemyBull, eg2, Quaternion.identity);
            c++;
            yield return new WaitForSeconds(EnemyData.ED[2]);
        }
    }

}

