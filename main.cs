using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class main : MonoBehaviour
{
    public int score;
    public bool GameOver;
    public bool gain;
    public Transform title;
    public Text scoreBoard;
    public Text scoreB;
    public Text ScoreG;
    public Transform gainPage;
    [SerializeField]
    public Transform collectedSound; //son vrai element
    [SerializeField]
    public Transform NoncollectedSound; //son faux element
    generator generator;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        GameOver = false;
        gain = false;
        scoreBoard.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        if (GameOver == true)
        {
            title.localPosition = new Vector3(0f, 0f, 0f);
            scoreB.text = scoreBoard.text;
            GameOver = false;
        }
        else if (gain == true)
        {
            gainPage.localPosition = new Vector3(0f, 0f, 0f);
            ScoreG.text = scoreBoard.text;
            gain = false;
        }

    }
    public void ScoreAdd(int val)
    {
        score += val;
        print(score);
        scoreBoard.text = score.ToString();
    }
    public void NewGame()
    {
        SceneManager.LoadScene(0);
    }
}
