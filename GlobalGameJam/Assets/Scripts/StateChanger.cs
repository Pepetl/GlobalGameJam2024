using UnityEngine;
using UnityEngine.UI;

public class StateChanger : MonoBehaviour
{
    [SerializeField] private string stateName; // Nombre del estado objetivo
    [SerializeField] private Button changeStateButton; // Referencia al botón

    private void Start()
    {
        // Asegurarse de que el botón llame a la función al ser presionado
        if (changeStateButton != null)
        {
            changeStateButton.onClick.AddListener(ChangeState);
        }
    }

    private void ChangeState()
    {
        // Intentar convertir el string en un estado del juego
        if (System.Enum.TryParse(stateName, out GameState newState))
        {
            GameManager.gameManager.SetGameState(newState);
        } else
        {
            Debug.LogError($"No se pudo convertir '{stateName}' a un GameState válido.");
        }
    }
}
