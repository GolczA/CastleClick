using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLifeTXT : MonoBehaviour
{
    // Start is called before the first frame update
    Text playerLife; 
    void Start()
    {
        playerLife = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        playerLife.text = PLCastle.plLife.ToString();
    }
}
