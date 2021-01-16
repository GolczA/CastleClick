using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollButtons : MonoBehaviour
{
    public float speed = 10.0f, checkPos = 0.0f;
    private RectTransform rec;
    // Start is called before the first frame update
    void Start()
    {
        rec = GetComponent<RectTransform>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (rec.offsetMin.x != checkPos) 
        {
                rec.offsetMin += new Vector2 (speed, rec.offsetMin.y);
                rec.offsetMax += new Vector2 (speed, rec.offsetMax.y);
        }
        
    }
}
