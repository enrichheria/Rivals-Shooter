using System.Collections;
using System.Collections.Generic;
using Terresquall;
using UnityEngine;

public class InputUI : BaseCanvasUI
{
    [SerializeField] private VirtualJoystick _inputMovement;
    [SerializeField] private VirtualJoystick _inputRotate;
    
    public override void Show()
    {
        base.Show();
    }

    public override void Hide()
    {
        base.Hide();
    }

    private void Update()
    {
        GameEvents.OnMoveInput?.Invoke(_inputMovement.GetAxis());
        GameEvents.OnRotateInput?.Invoke(_inputRotate.GetAxis());
    }
}
