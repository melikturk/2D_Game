using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barrier : MonoBehaviour
{
    public Rigidbody2D rd2;
    public float moveSpeed=5;
    // Start is called before the first frame update
    void Start()
    {
        rd2 = GetComponent<Rigidbody2D>();//Kod diyor ki; RigidBody2D componentini al rd2ye ekle.
        rd2.velocity = new Vector2(1, 0) * moveSpeed; //velocity bize hız verir. Kod bize x yönünde başlangıç hızı veriyor. moveSpeed ile 5 birimlik bir hız sağladım.
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
