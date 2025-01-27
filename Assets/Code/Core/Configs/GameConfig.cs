using System.Collections.Generic;
using NaughtyAttributes;
using UnityEngine;

[CreateAssetMenu(menuName = AssetDefineConstants.CONFIGS + "GameConfig", fileName = "GameConfig")]
public class GameConfig : Config
{
    [BoxGroup("Database")] public ModuleAssets Modules;
    
    [BoxGroup("Controller")] public PlayerCamera playerCamera;
    [BoxGroup("Controller")] public PlayerGame PlayerGameController;

    public override void Init()
    {
        
    } 
}