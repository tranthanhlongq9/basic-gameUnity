﻿using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 8f;
    public float lifeDuration = 2f;
    public int damage = 5;

    private float lifeTimer;
    private bool shotByPlayer; 

    public bool ShotByPlayer { get { return shotByPlayer; } set { shotByPlayer = value; } }

    // Start is called before the first frame update
    void OnEnable()
    {
        lifeTimer = lifeDuration;
    }

    // Update is called once per frame
    void Update()
    {
        // lam vien dan di chuyen
        transform.position += transform.forward * speed * Time.deltaTime;

        // kiểm tra xem viên đạn nên bị phá hủy hay không
        lifeTimer -= Time.deltaTime;
        if(lifeTimer <= 0f)
        {
            gameObject.SetActive(false); 
        }
    }
}
