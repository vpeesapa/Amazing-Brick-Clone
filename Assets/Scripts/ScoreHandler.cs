using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreHandler : MonoBehaviour
{
    [SerializeField] private Text scoreText;

    private int score = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            score += 1;
            scoreText.text = score.ToString();

            gameObject.GetComponent<BoxCollider2D>().enabled = false;
        }
    }
}
