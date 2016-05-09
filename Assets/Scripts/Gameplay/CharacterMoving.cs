using UnityEngine;
using System.Collections;
using UnityStandardAssets._2D;

public class CharacterMoving : MonoBehaviour
{
    public float xAxis;


    void OnEnable()
    {
        EasyJoystick.On_JoystickMove += On_JoystickMove;
        EasyJoystick.On_JoystickMoveEnd += On_JoystickMoveEnd;
    }

    void OnDisable()
    {
        EasyJoystick.On_JoystickMove -= On_JoystickMove;
        EasyJoystick.On_JoystickMoveEnd -= On_JoystickMoveEnd;
    }

    void OnDestroy()
    {
        EasyJoystick.On_JoystickMove -= On_JoystickMove;
        EasyJoystick.On_JoystickMoveEnd -= On_JoystickMoveEnd;
    }


    void On_JoystickMoveEnd(MovingJoystick move)
    {
        //xAxis = move.joystickAxis.x;
    }

    void On_JoystickMove(MovingJoystick move)
    {
        Debug.Log("On_JoystickMove");
        xAxis = move.joystickAxis.x;
    }

    void On_JoysticStartMove(MovingJoystick move)
    {
    }

    public void FixedUpdate()
    {
        gameObject.GetComponent<PlatformerCharacter2D>().Move(xAxis, false, false);
    }
}
