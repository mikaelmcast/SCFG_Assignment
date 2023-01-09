using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using InfimaGames.LowPolyShooterPack;

public class HitBox : MonoBehaviour
{
    public Health health;

    public void OnProjectileHit(Projectile projectile, int multiplier)
    {
        health.TakeDamage((projectile.GetComponent<DamageGiven>().damageGiven) * multiplier);
    }

}