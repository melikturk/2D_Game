using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class moveee : MonoBehaviour
{
    public Rigidbody2D rbb2 { get { return GetComponent<Rigidbody2D>(); } }
    public float moveSpeed = 5;
    public Rigidbody2D bombPrefab;
    public Transform bombSpawn;

    float score;
    public Text scoreText;
    void Start()
    {
        rbb2.velocity = new Vector2(-1, 0) * moveSpeed; //velocity bize hız verir. Kod bize x yönünde başlangıç hızı veriyor. moveSpeed ile 5 birimlik bir hız sağladım.
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
            Shoot();
    }
    public void Shoot()
    {

        var bomb = Instantiate(bombPrefab, bombSpawn.position, Quaternion.identity);
        bomb.AddForce(1000 * Vector2.down);
        Destroy(bomb.gameObject, 2f);

    }
    public void MakeScore()
    {
        if (score != 0)
        {
            score = score - 10;
        }
        else
        {
            score = 100;
        }
        scoreText.text = score.ToString();
    }
}
