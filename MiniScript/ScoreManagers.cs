using UnityEngine;
using TMPro;

public class ScoreManagers : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public static int finalScore;

    float score = 0;

    void Update()
    {
        score += Time.deltaTime * 10;
        scoreText.text = "Score: " + Mathf.FloorToInt(score);
        finalScore = Mathf.FloorToInt(score);
    }
}