using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    int score = 0;
    public int streak = 0;
    int scoreBase = 100;
    int multi2 = 6, multi3 = 12, multi4 = 18;
    int ScorePoint;
    int totalScore;
    [SerializeField] TextMeshProUGUI ScoreUI,ScoreMultiUI;
    private void Awake()
    {
        instance = this;
    }
    void scoreUpdate()
    {
        totalScore = totalScore + ScorePoint;
        ScoreUI.text = "" + totalScore;
    }
    public void scoreMultiplayer()
    {
        // Verificamos la racha y ajustamos el multiplicador
        if (streak >= multi4)
        {
            ScorePoint = scoreBase * 4;  // Multiplicador 4x para racha >= 18
            ScoreMultiUI.text = "X4" ;
        } else if (streak >= multi3)
        {
            ScorePoint = scoreBase * 3;  // Multiplicador 3x para racha >= 12
            ScoreMultiUI.text = "X3";
        } else if (streak >= multi2)
        {
            ScorePoint = scoreBase * 2;  // Multiplicador 2x para racha >= 6
            ScoreMultiUI.text = "X2";
        } else
        {
            ScorePoint = scoreBase;  // Puntaje base si no se alcanza ningún multiplicador
            ScoreMultiUI.text = "X1";
        }

        // Actualizamos el puntaje
        scoreUpdate();
    }
}