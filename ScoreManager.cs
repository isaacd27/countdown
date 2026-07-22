using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScoreManager : MonoBehaviour
{
// TODO: FINAL score text?

    public TMP_Text scoretext;
    float score;
    //should we make scoremanager not destory on load?
    public void addScore(int delta)
    {
        score += delta;
    }

    public float getscore()
    {
        return score;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoretext.text = score.ToString("00000");
    }
}
