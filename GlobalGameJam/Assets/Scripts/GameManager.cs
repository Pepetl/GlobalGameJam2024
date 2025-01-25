using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum GameState
{
    None,
    MainMenu,
    Playing,
    RestartGame,
    GameOver

}

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;

    // Estado actual del juego
    public static GameState gameState = GameState.None;

    private void Awake()
    {
        if (gameManager != null && gameManager != this)
        {
            Destroy(gameObject);
            return;
        }
        gameManager = this;
        gameState = GameState.None;

    }
    public void SetGameState(GameState newState)
    {
        if (gameState == newState)
        {
            Debug.LogWarning($"El juego ya est� en estado {newState}");
            return;
        }

        gameState = newState;
        switch (gameState)
        {
            case GameState.None:

                break;
            case GameState.MainMenu:

                break;
            case GameState.Playing:

                break;
            case GameState.RestartGame:

                break;  
            case GameState.GameOver:

                break;
            default:

                break;
        }
    }
    public GameState GetGameState()
    {
        return gameState;
    }


}
