using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum GameState
{
    None,
    MainMenu1,
    MainMenu2,
    MainMenu3,
    Playing,
    RestartGame,
    GameOver,
    Level1

}

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;

    // Estado actual del juego
    public static GameState gameState = GameState.None;
    public GameObject Menu1, Menu2, Menu3, Fondo1, Fondo2;
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
            case GameState.MainMenu1:
                Menu1.SetActive(true);
                Menu2.SetActive(false);
                Menu3.SetActive(false);
                Fondo1.SetActive(true);
                Fondo2.SetActive(false);

                break;
            case GameState.MainMenu2:
                Menu1.SetActive(false);
                Menu2.SetActive(true);
                Menu3.SetActive(false);
                Fondo1.SetActive(false);
                Fondo2.SetActive(true);
                break;
            case GameState.MainMenu3:
                Menu1.SetActive(false);
                Menu2.SetActive(false);
                Menu3.SetActive(true);
                Fondo1.SetActive(false);
                Fondo2.SetActive(true);

                break;
            case GameState.Playing:

                break;
            case GameState.RestartGame:

                break;
            case GameState.GameOver:

                break;

            case GameState.Level1:
                SceneManager.LoadScene("NivelPlantilla");

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
