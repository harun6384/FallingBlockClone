using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreCalc : MonoBehaviour
{
    public float score = 20f;
    public GameObject block;
    public TMP_Text curScore;
    private void Start()
    {
        FindObjectOfType<FallinBlock>().OnScore += OnScoreCalculate;
        
    }
    private void Update()
    {

        curScore.text = Mathf.Ceil(score).ToString();
    }
    void OnScoreCalculate()
    {
        score += score ;
    }


}
