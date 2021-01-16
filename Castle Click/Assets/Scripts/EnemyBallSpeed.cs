using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBallSpeed : MonoBehaviour
{
    // На префаб мяча или снаряда врага
    public Vector2 directionEnemy; // в инспекторе поставь значения Х = 1, y = 0 гравитация  0,05 или 0 (для выстрела по прямой)
    // или x = 1, y = 0.25 гравитация 0.25 для выстрела навесом 
    Rigidbody2D rbd;
    private void Start()
    {
        rbd = GetComponent<Rigidbody2D>();
        
    }
    void FixedUpdate()
    {
        //transform.Translate(directionEnemy * 0.25f);
        rbd.AddForce(directionEnemy * 1f, ForceMode2D.Impulse);
    }
}
