using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class ShipStats
{
    [Range(1, 5)]
    public int maxHealth;
    [HideInInspector]
    public int currentHealth;
    [HideInInspector]
    public int maxLifes = 5;
    [HideInInspector]
    public int currentLifes = 5;

    public float shipSpeed;
    public float fireRate;
}
