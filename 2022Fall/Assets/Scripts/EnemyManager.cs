using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public Enemy enemy;

    private float _speed;
    
    // Start is called before the first frame update
    void Start()
    {
        AssignValues();
    }

    void AssignValues()
    {
        _speed = enemy.enemySpeed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
