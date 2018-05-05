﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag_drop : MonoBehaviour {

    public Muda_Tag Tag;
    private bool drag = false;
    private float distancia;
    public GameObject player;
    public Vector3 posicao_original;


	// Use this for initialization
	void Start () {
        posicao_original = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (drag)
        {
            //Criando um raycast pra verificar se o mouse está sobre o objeto
            Ray Raycast = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 ponto_ray = Raycast.GetPoint(distancia);
            transform.position = ponto_ray;
        }
	}

    private void OnMouseDown()
    {
        distancia = Vector3.Distance(transform.position, Camera.main.transform.position);
        drag = true;
    }

    private void OnMouseUp()
    {
        transform.position = posicao_original;
        drag = false;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.tag == "Player")
        {
            transform.position = posicao_original;
            drag = false;
            Tag.TagVermelho();
        }
    }

   

}
