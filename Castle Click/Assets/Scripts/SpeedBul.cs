using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class SpeedBul : MonoBehaviour
{
    // накинуть на префаб ядра игрока
    public Vector2 direction; // в инспекторе поставь значения Х = 1, y = 0 гравитация  0,05 или 0 (для выстрела по прямой)
    // или x = 1, y = 0.25 гравитация 0.35 для выстрела навесом 
    // потом этот показатель будет менятся в зависимости от прокачки мяча, но пока = 0.2 
    Rigidbody2D rbd;

    private void Start()
    {
        rbd = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        //transform.Translate(direction.normalized * 1f);
        rbd.AddForce(direction * 1f, ForceMode2D.Impulse);
    }
}
