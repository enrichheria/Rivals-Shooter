using System.Collections.Generic;
using NaughtyAttributes;
using UnityEngine;

[CreateAssetMenu(menuName = AssetDefineConstants.CONFIGS + "GameConfig", fileName = "GameConfig")]
public class GameConfig : Config
{
    [BoxGroup("Controller")] public PlayerCamera playerCamera;
    [BoxGroup("Controller")] public PlayerController PlayerGameController;

    public override void Init()
    {
        
    } 
}