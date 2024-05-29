using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public static int scoreValue = 0;
    public static int exp = 0;
    public static int expreq = 6;
    public GameObject buff;
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
        
        if(exp >= expreq)
        {
            lvlup();
        }
    }

    void lvlup()
    {
        buff.SetActive(true);
        exp = 0;
        expreq = expreq + 2;
    }
}
