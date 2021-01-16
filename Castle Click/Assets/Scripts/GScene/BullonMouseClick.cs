using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BullonMouseClick : MonoBehaviour
{
    // этот скрипт надевается на кнопку. При помощи его появляются шары игрока при нажатии
    // объект Shere1 и Shere сюда нужно вставить объект пушки игрока, что бы мячи влетали из пушек
    public GameObject playerG1;
    public GameObject playerG2;
    public GameObject MainBullPr;
    Vector3 pg1, pg2;
    private void Start()
    {
        pg1 = playerG1.transform.position;
        pg2 = playerG2.transform.position;
    }
    void OnMouseDown()
    {
        if(EnemyData.check == false)
        {
            Instantiate(MainBullPr, pg1, Quaternion.identity);
            Instantiate(MainBullPr, pg2, Quaternion.identity);
        }
    }
}
