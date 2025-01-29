using System;
using System.Collections.Generic;
using UnityEngine;

public class GameContext : ICoreSystem
{
    public PlayerCamera PlayerCamera { get; private set; }
    
    public PlayerController PlayerGame { get; private set; }

    private static readonly Dictionary<Type, BaseMonoController> _controllers = new Dictionary<Type, BaseMonoController>();

    public void Init()
    {
        
    }

    public void DeInit()
    {
        
    }

    public void Execute()
    {
        
    }

    public void SpawnPlayer()
    {
        if(PlayerGame != null)
            GameObject.Destroy(PlayerGame.gameObject);
        
        if(PlayerCamera != null)
            GameObject.Destroy(PlayerCamera.gameObject);
        
        PlayerCamera = ContextUtils.SpawnManager<PlayerCamera>(_controllers, Configs.Get<GameConfig>().playerCamera);
        PlayerGame = ContextUtils.SpawnManager<PlayerController>(_controllers, Configs.Get<GameConfig>().PlayerGameController);
    }
}