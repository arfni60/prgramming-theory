using UnityEngine;

public class ClickableItem : MonoBehaviour
{
    public ScoreManager scoreManager;

    public int scoreToGive = 1;

    private void OnMouseDown() 
    {
        //play sound and particleeffect
        scoreManager.AddToScore(scoreToGive);
        Destroy(gameObject);
    }
}
