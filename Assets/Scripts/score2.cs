using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score2 : MonoBehaviour
{
    public player_one_move pl;
    public moveee p2;
    void Start()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        TagManager tm = collision.gameObject.GetComponent<TagManager>();
        if (tm != null)
        {
            if (tm.tagger.Equals(Tager.One_Player))
            {
                //rightracket makescore
                pl.MakeScore();
            }
            else if (tm.tagger.Equals(Tager.bar))
            {
                Destroy(gameObject);
            }

        }
    }
}


