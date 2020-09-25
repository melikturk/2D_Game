using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score1 : MonoBehaviour
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
            if (tm.tagger.Equals(Tager.Two_Player))
            {
                //rightracket makescore
                p2.MakeScore();
            }
            else if (tm.tagger.Equals(Tager.bar))
            {
                Destroy(gameObject);
            }
            
        }
        }
    }
  

