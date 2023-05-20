using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreSystem : MonoBehaviour
{
    float timer;
    public TMP_Text scoreText;
    public TMP_Text scoreTextGOv;


    void Update()
    {
        timer += Time.deltaTime;
        int scoreTimer = (int)timer;
        scoreText.text = scoreTimer.ToString();

        scoreTextGOv.text = scoreTimer.ToString();
    }


}
