﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prefabs_helicoptero : MonoBehaviour
{
    public float velocidade;
    public bool direcao;
    public Rigidbody rb;
    private Animator animator;
    public GameObject Player;
    public GameObject helicoptero;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = gameObject.transform.GetComponent<Animator>();
        Player = GameObject.Find("Player");
        helicoptero = GameObject.Find("helicoptero");
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine("deSpawn");
        float translation = Time.deltaTime * 10;
        transform.Translate(-velocidade * Time.deltaTime, 0, 0);
    }

    /*
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
        }
    }*/
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player_azul")
        {
            Destroy(collision.gameObject);
        }

        else if (collision.tag == "Player_vermelho")
        {
            Destroy(collision.gameObject);
        }
        else if (collision.tag == "Player_verde")
        {
            Destroy(collision.gameObject);
        }
        else if (collision.tag == "Player_azul")
        {
            Destroy(collision.gameObject);
        }
        else if (collision.tag == "Player_roxo")
        {
            Destroy(collision.gameObject);
        }

    }

    IEnumerator deSpawn()
    {
        yield return new WaitForSeconds(6);
        Destroy(gameObject);
    }
}