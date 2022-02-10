using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [Header("Bullets information")]
    public GameObject bullet;
        // Cantidad de balas que se crear�n al inicio del c�digo
    public int bulletCapacity;

    [Header("Variables del disparo")]
    public int ammo;
    public int fireRate;

    private bool cooldown;
    void Awake()
    {
        // Las balas ya estar�n creadas para ahorrar recursos, no se instanciar�n onGame
        for (int i = 0; i < bulletCapacity; i++)
        {
            Instantiate(bullet, transform.position, transform.rotation);
        }
    }

    void Update()
    {
        // Si el jugador tiene munici�n y no est� en cooldown, podr� disparar
        if (Input.GetKey(KeyCode.E) && ammo > 0 && !cooldown)
        {
            StartCoroutine(FireRate());
        }
    }

    IEnumerator FireRate()
    {
        cooldown = true;
        yield return new WaitForSeconds(fireRate);
        cooldown = false;
    }
}
