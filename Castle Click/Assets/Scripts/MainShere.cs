using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainShere : MonoBehaviour
{
    // таран это формально Main объект
    // это для вызова текста на экран, растоянние до победы или поражения.
    // нужно создать текст на экране куда будут выводиться эти данные
    public Text SpeedRead; 

    // при достижении это точки игрок выигрывает (у меня эта точка стоит перед замком) тебе накинуть на замок врага
    public GameObject EnemyGate;
    // при достижении этой точки комп выигрывает (у меня эта точка стоит перед замком) тебе накинуть на замок playera
    public GameObject PlayerGate;
    // Меню которое появляется при победе (изначально отключен)
    public GameObject WinMenu;
    // меню которое появляется если игрок проиграл (изначально отключен)
    public GameObject LoseMenu;
    // тебе это нахер не надо, собирает в массив шарики оставшиеся после победы или поражения и уничтожает их
    GameObject[] BullForDel;
    // это будет позицией тарана 
    float oldPosition;
    // для счетчика столкновений
    int t = 0;
    bool tach = false;




    
    void Start ()
    {
        float oldPosition = transform.position.x; 
    }
    
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "PlayerBull(Clone)")
        {
            Destroy(col.gameObject, 0.2f);
        }
        else if (col.gameObject.name == "EnemyBull(Clone)")
        {
            // считаем количество столкновений игровых шаров с тараном, когда шары закончатся , побдеил игрок
            t++;
            Destroy(col.gameObject, 0.2f);
        }
        else if (col.gameObject.name == "PlayerGate")
        {
            LoseMenu.SetActive(true);
            BullForDel = GameObject.FindGameObjectsWithTag("Bull");
            foreach (GameObject rw in BullForDel)
            {
                Destroy(rw);
            }

        }
        else if (col.gameObject.name == "EnemyGate")
        {

            WinMenu.SetActive(true);
            BullForDel = GameObject.FindGameObjectsWithTag("Bull");
            foreach (GameObject rw in BullForDel)
            {
                Destroy(rw);
            }
            
            EnemyData.levelUp++;
            
        }
        // условия победы, если комп выпустил 10 шаров и  не победил 
        // потом цифра заменитя на DataEnem.bullQanity
        // пока оставляем эту реализайию что бы бытсрее проходить уровни
        if (t >= 39 && tach == false )
        {
            if (oldPosition > 0)
            {
                WinMenu.SetActive(true);
                BullForDel = GameObject.FindGameObjectsWithTag("Bull");
                foreach (GameObject rw in BullForDel)
                {
                    Destroy(rw);
                }
                
                EnemyData.levelUp++;
                EnemyData.MLev(EnemyData.levelUp);
                tach = true;
                Debug.Log(EnemyData.maxLevel.ToString() + " + MAXLEVEL");
                EnemyData.Save();

                //foreach (bool LU in EnemyData.LevUp)
                //{
                //    if (LU == true)
                //    {
                //        EnemyData.levelUp++;
                //        Debug.Log(EnemyData.levelUp.ToString());
                //    }
                //}

            }
            else
            {
                LoseMenu.SetActive(true);
                BullForDel = GameObject.FindGameObjectsWithTag("Bull");
                foreach (GameObject r in BullForDel)
                {
                    Destroy(r);
                }
            }

        }
    }


    // это реализация, в виде текста сколько осталось доталкать до победы
    void FixedUpdate() 
    {
        SpeedRead.text = oldPosition.ToString();
        oldPosition = transform.position.x;
    }

}
