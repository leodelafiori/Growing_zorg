using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muda_Tag : MonoBehaviour {

    public GameObject player;

    public void TagVermelho()
    {

        player.transform.localScale = new Vector3(5F, 5f, 0);
        player.tag = "Player_vermelho";

    }

    public void TagAzul()
    {
        player.transform.localScale = new Vector3(2F, 2f, 0);
        player.tag = "Player_azul";
    }

    public void Tagverde()
    {
        player.transform.localScale = new Vector3(3F, 3f, 0);
        player.tag = "Player_verde";
    }
}
