using UnityEngine;

public class GoalLine : MonoBehaviour, IGoal
{
    [SerializeField] private bool isLeftLİne;
    
    public void Goal(GameObject ball)
    { 
        Destroy(ball.gameObject);
        ScoreUpdate();
        //Spawn new ball
    }

    private void ScoreUpdate()
    {
        if (isLeftLİne)
        {
            ScoreManager.Instance.rightScore++;
            UIManager.Instance.rightText.text = ScoreManager.Instance.rightScore.ToString();;
        }
        else
        {
            ScoreManager.Instance.leftScore++;
            UIManager.Instance.leftText.text = ScoreManager.Instance.leftScore.ToString();;
        }
    }
}