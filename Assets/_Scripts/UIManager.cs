using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI ScoreboardTMP;
    public GameObject[] LiveToken;
    public GameObject GameOverScreen;

    // Update is called once per frame
    private void Start()
    {
        GameOverScreen.SetActive(false);
    }

    void Update()
    {
        if(GameManager._gameOver)
        {
            GameOverScreen.SetActive(true);
            return;
        }
        ScoreboardTMP.text = GameManager.Score.ToString();

        for (int i = 0; i < LiveToken.Length; i++)
        {
            LiveToken[i].SetActive(false);
        }
        for (int i = 0; i < GameManager.Lives; i++)
        {
            LiveToken[i].SetActive(true);
        }
    }
}
