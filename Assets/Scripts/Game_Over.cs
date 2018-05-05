using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Game_Over : MonoBehaviour {

    public GameObject player;
    public GameObject tela_game_over;
    public GameObject tela_game;
    public TextMeshProUGUI p_final;
    public TextMeshProUGUI p;

    public int ponto_i;
    public int ponto_externo;
    int index = 0;

    // Use this for initialization
    void Start () {
        
       
    }
	
	// Update is called once per frame
	void Update () {

	 if (player == null)
        {
            

            if (index < 1)
            {

                GetComponent<AudioSource>().Play();
                index = 1;
            }

            // = GetComponent<AudioSource>();
            print(ponto_i);
            instancia_game_over();
        }	
	}

  

    // Buscar o valor de ponto importando a classe

    public void instancia_game_over()
    {
        GetComponent<Camera>().GetComponent<AudioSource>().Pause();
        Time.timeScale = 0;
        tela_game_over.SetActive(true);
        tela_game.SetActive(false);
        p_final.text = p.text;
         

    }

}
