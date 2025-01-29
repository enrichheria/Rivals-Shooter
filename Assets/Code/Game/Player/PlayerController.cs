using System.Collections;
using System.Collections.Generic;
using Lightbug.CharacterControllerPro.Core;
using UnityEngine;

public class PlayerController : BaseMonoController
{
    [SerializeField] private CharacterBody _characterBody;
    [SerializeField] private CharacterActor _characterActor;
    
    private Locomotion _locomotion;
    
    public override void Init()
    {
        _locomotion = new Locomotion(_characterBody, _characterActor);
        
        GameEvents.OnMoveInput += Move;
    }

    public override void DeInit()
    {
        GameEvents.OnMoveInput -= Move;
    }

    public override void Execute()
    {
        
    }

    private void Move(Vector2 input)
    {
        Vector3 convert = new Vector3(input.x, 0, input.y);
        
        _locomotion.Move(convert);
    }
}
