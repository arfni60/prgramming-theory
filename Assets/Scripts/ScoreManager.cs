using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int score;

    public void AddToScore(int amount)
    {
        score += amount;
    }
}
