using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Menu_configs : MonoBehaviour {

    public GameObject como_jogar;
    public GameObject game_over;
    public GameObject main_menu;
    public bool gameover;

    private void Update()
    {
        if ( game_over.active)
        {
            print("oioioioi");
        }
    }

    public void Muda_cena(string nome_cena)
    {
        GetComponent<AudioSource>().Play();
        Application.LoadLevel(nome_cena);
        
    }

    public void sair()
    {
        GetComponent<AudioSource>().Play();
        Application.Quit();
    }

    public void instrucoes()
    {
        GetComponent<AudioSource>().Play();
        main_menu.SetActive(false);
        como_jogar.SetActive(true);
    }

    public void instrucoes_voltar()
    {
        GetComponent<AudioSource>().Play();
        main_menu.SetActive(true);
        como_jogar.SetActive(false);

    }
    
}
