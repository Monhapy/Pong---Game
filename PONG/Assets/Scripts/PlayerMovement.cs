using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Move
    // Clamp Move
    // GetInput 
    // Which Player

    [SerializeField] private float moveSpeed;
    [SerializeField] private bool isPlayerOne;
    private Vector3 _moveVector;
    private float _verticalInput;
    
    private void Update()
    {
        PlayerInput.HandleInputs();
        GetInput();
        Move();
    }

    private void Move()
    {
        _moveVector = new Vector3(0f, _verticalInput, 0f);
        
        var position = transform.position;
        position += _moveVector * (moveSpeed * Time.deltaTime);
        position = new Vector3(position.x,Mathf.Clamp(position.y, -4.15f, 4.15f), position.z);
        
        transform.position = position;
    }

    private void GetInput()
    {
        
        switch (isPlayerOne)
        {
            case true :
                _verticalInput = PlayerInput.PlayerOneInput();
                break;
            
            case false:
                _verticalInput = PlayerInput.PlayerTwoInput();
                break;
        }
    }

}