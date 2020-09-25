using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;
using UnityEngine.UI;

public class player_one_move : MonoBehaviour
{
    public Rigidbody2D rbb2 { get { return GetComponent<Rigidbody2D>(); } }
    public float moveSpeed = 5;
    public string AxisName;
    public Rigidbody2D bombPrefab;
    public Transform bombSpawn;
    public player_one_move pl;
    public moveee p2;

    float score;
    public Text scoreText;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveAxis = Input.GetAxis(AxisName); //Üsttekinden farklı olarak kolların bilgisini programdan isteyip gönderdik.
        rbb2.velocity = new Vector2(moveAxis, 0) * moveSpeed; //racketlerimi x yönünde hareket ataması yaptım.

        if (Input.GetKeyDown(KeyCode.Space))
            Shoot();
    }
    public void MakeScore()
    {
        if (score != 0) { 
        score=score-10;
        }
        else
        {
            score = 100;
        }
        scoreText.text = score.ToString();
    }
    public void Shoot()
    {

        var bomb = Instantiate(bombPrefab, bombSpawn.position, Quaternion.identity);
        bomb.AddForce(1000 * Vector2.up);
        Destroy(bomb.gameObject, 2f);

    }
   
}
