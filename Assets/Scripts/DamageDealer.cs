using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageDealer : MonoBehaviour
{

    //Config parameters
    [SerializeField] int damage = 100;

    public int GetDamage() { return damage; }

    public void Hit()
    {
        Destroy(gameObject);
    }
}
