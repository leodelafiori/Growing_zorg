using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prefabs_cientista : MonoBehaviour {
    public float velocidade;
    public bool direcao;
    public Rigidbody rb;
    private Animator animator;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = gameObject.transform.GetComponent<Animator>();
    }
           
    // Update is called once per frame
    void Update()
    {
        float translation = Time.deltaTime * 10;
        transform.Translate(-velocidade * Time.deltaTime, 0, 0);


    }

    
}
