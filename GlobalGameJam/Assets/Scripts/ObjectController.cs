using UnityEngine;
using System;

public class ObjectController : MonoBehaviour
{
    public float lifeTime =2f;  // Tiempo de vida antes de desactivarse

    private void OnEnable()
    {
        Invoke("DeactivateBullet", lifeTime);
    }

    private void DeactivateBullet()
    {
        gameObject.SetActive(false);
    }
}