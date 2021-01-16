using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyLIfeTXT : MonoBehaviour
{
    // Start is called before the first frame update
    Text enemLife;
    
    void Start()
    {
        enemLife = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        enemLife.text = EnemyData.ED[1].ToString();        
    }
}
