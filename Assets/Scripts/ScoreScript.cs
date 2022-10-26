using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    //increase score
    private int score;
    public Text scoreTxt;


    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            //destroy obstacle + increase score
            Destroy(other.gameObject);

            score++;
            scoreTxt.text = "Score: " + score;
        }
    }
}
