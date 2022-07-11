using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class FallinBlock : MonoBehaviour
{
    //public TMP_Text curScore;
    public Vector2 speedMinMax;
    float speed;
    //public float score = 20f;
    //public float finScore;
    float visibleHeightThreshold;
    public Action OnScore;

    private void Start()
    {

        speed = Mathf.Lerp(speedMinMax.x, speedMinMax.y, Difficulty.GetDifficultyPercent());
        visibleHeightThreshold = -Camera.main.orthographicSize - transform.localScale.y;
        //curScore = GameObject.FindObjectOfType<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime, Space.Self);
        if (transform.position.y < visibleHeightThreshold)
        {
            //calcScore();
            //PlayerPrefs.SetFloat( "score", PlayerPrefs.GetFloat("score") + score) ;
            //curScore.text = Mathf.Ceil(PlayerPrefs.GetFloat("score")).ToString();
            if (OnScore != null)
            {
                OnScore();
            }
            Destroy(gameObject);
        }
    }

    //void calcScore()
    //{
    //    score = score * gameObject.transform.localScale.x;
        
    //}
}
