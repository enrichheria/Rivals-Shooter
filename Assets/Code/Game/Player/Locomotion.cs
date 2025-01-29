using Lightbug.CharacterControllerPro.Core;
using UnityEngine;

public class Locomotion
{
    private CharacterBody _body;
    private CharacterActor _actor;

    private Vector3 _worldPosition;

    public Locomotion(CharacterBody body, CharacterActor actor)
    {
        _body = body;
        _actor = actor;

        _worldPosition = _actor.transform.position;
    }

    public void Move(Vector3 direction)
    {
        _worldPosition += direction * Time.deltaTime;
        
        _actor.Move(_worldPosition);
    }
}