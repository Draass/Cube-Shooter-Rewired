using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Enemy", menuName = "Scriptable Objects/EnemyData")]
public class EnemyData : ScriptableObject
{

    public float maxHealth;
    public float maxSpeed;

}
