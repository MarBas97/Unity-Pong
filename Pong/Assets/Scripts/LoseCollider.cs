using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoseCollider : MonoBehaviour
{
    public Transform enemy;
    private int pscore = 0;
    private int escore = 0;
    void OnTriggerEnter2D(Collider2D other)
    {

        //Destroys gameobject if its tag is Ball
        if (other.gameObject.tag == "ball")
        {
            Destroy(other.gameObject);
            enemy.position = new Vector3(15.8f,6f, 0);
        }
        if(gameObject.tag == "player_win")
        {
            AddPlayerScore();
        }
        if (gameObject.tag == "enemy_win")
        {
            AddEnemyScore();
        }

    }

    private void AddEnemyScore()
    {
        escore++;
        GameObject.Find("EnemyScore").GetComponent<Text>().text = escore.ToString();
    }

    public void AddPlayerScore()
    {
        pscore++;
        GameObject.Find("PlayerScore").GetComponent<Text>().text = pscore.ToString(); 
    }

}
