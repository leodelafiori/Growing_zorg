using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muda_Tag : MonoBehaviour {

    public GameObject player;

    public void TagVermelho() {

        player.transform.localScale += new Vector3(2F, 2f, 0);
        player.tag = "Player_vermelho";

    }
}
