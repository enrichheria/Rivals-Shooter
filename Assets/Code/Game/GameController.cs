using UnityEngine;

public class GameController : MonoBehaviour
{
    private void Start()
    {
        Services.Game.Load();
        Services.UI.Get<GameUI>().Show();
        Services.Game.Context.SpawnPlayer();
    }
    
    private void OnDestroy()
    {
        Services.UI.Get<GameUI>().Hide();
    }
}