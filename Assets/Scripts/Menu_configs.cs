using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_configs : MonoBehaviour {

    public GameObject como_jogar;
    public GameObject game_over;
    public GameObject main_menu;

    public void Muda_cena(string nome_cena)
    {
        Application.LoadLevel(nome_cena);
    }

    public void sair()
    {
        Application.Quit();
    }

    public void instrucoes()
    {
        main_menu.SetActive(false);
        como_jogar.SetActive(true);
    }

    public void instrucoes_voltar()
    {
        main_menu.SetActive(true);
        como_jogar.SetActive(false);

    }
}
