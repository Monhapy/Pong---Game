using System;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private IGoal _goal;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.GetComponent<IGoal>() != null)
        {
            _goal = other.gameObject.GetComponent<IGoal>();
            _goal.Goal(gameObject);
        }
    }
}