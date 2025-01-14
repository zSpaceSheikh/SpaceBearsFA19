﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawner : MonoBehaviour
{
    public Transform otherSpawn;
    public Transform bearSpawn;

    public AudioSource Death;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        var lay = collision.gameObject.layer;
        if (lay == 8 || lay == 9 || lay == 10)
        {
            collision.gameObject.transform.position = bearSpawn.position;
            Death.Play();
            return;
        }
        collision.gameObject.transform.position = otherSpawn.position;
    }
}
