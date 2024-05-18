using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public static int scoreValue = 0;
    private TextMeshProUGUI Scores;
    // Start is called before the first frame update
    void Start()
    {
        Scores = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        Scores.text = "Score: " + scoreValue;
    }
}
