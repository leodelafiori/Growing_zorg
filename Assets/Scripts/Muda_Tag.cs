using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muda_Tag : MonoBehaviour {

    public SpriteRenderer player_sprite;
    public GameObject player;
    public Troca_sprite troca;

    private void Start()
    {
        
    }

    public void TagVermelho()
    {
        player.transform.position = new Vector3(-4, -0.6f, 0);
        player.transform.localScale = new Vector3(5F, 5f, 0);
        player.tag = "Player_vermelho";
        troca.troca_vermelho();
    }

    public void TagAzul()
    {
        player.transform.position = new Vector3(-4, -0.8f, 0);
        player.transform.localScale = new Vector3(2F, 2f, 0);
        player.tag = "Player_azul";
        troca.troca_azul();
    }

    public void Tagverde()
    {
        player.transform.position = new Vector3(-4, -0.6f, 0);
        player.transform.localScale = new Vector3(3F, 3f, 0);
        player.tag = "Player_verde";
        troca.troca_verde();
    }

    public void Tagroxo()
    {
        player.transform.position = new Vector3(-4, 0f, 0);
        player.transform.localScale = new Vector3(2.5F, 2.5f, 0);
        player.tag = "Player_roxo";
        troca.troca_verde();
    }

}
