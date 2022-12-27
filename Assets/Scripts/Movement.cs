﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    void Update()
    {
        Vector2 moveDirection = new Vector2(
            Input.GetAxisRaw("Horizontal"),
            Input.GetAxisRaw("Vertical")).normalized;
        transform.Translate(moveDirection * speed * Time.deltaTime);
    }
}
