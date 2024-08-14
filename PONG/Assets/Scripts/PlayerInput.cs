using UnityEngine;

public static class PlayerInput
{
    private static float _verticalInputP1;
    private static float _verticalInputP2;
    public static float PlayerOneInput()
    {
        if (Input.GetKey(KeyCode.W))
        {
            _verticalInputP1 = 1;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            _verticalInputP1 = -1;
        }
        else
        {
            _verticalInputP1 = 0;
        }
        return _verticalInputP1;

    }
    public static float PlayerTwoInput()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            _verticalInputP2 = 1;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            _verticalInputP2 = -1;
        }
        else
        {
            _verticalInputP2 = 0;
        }
        return _verticalInputP2;

    }

    public static void HandleInputs()
    {
        PlayerOneInput();
        PlayerTwoInput();
    }
    
}
