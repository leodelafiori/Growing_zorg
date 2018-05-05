using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Troca_sprite : MonoBehaviour {

    private SpriteRenderer sprite;
    public Sprite verde;
    public Sprite vermelho;
    public Sprite azul;

    private void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    public void troca_verde()
    {
        sprite.sprite = verde;
    }

    public void troca_vermelho()
    {
        sprite.sprite = vermelho; 
    }

    public void troca_azul()
    {
        sprite.sprite = azul;
    }
}
