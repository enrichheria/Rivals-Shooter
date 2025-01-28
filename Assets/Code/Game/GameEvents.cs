using System;
using UnityEngine;

public static class GameEvents
{
    public static Action<Vector2> OnMoveInput;
    public static Action<Vector2> OnRotateInput;
}