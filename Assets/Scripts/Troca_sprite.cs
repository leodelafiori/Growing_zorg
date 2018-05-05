using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Troca_sprite : MonoBehaviour {

    private SpriteRenderer sprite;
    public Sprite[] verde;
    public Sprite[] vermelho;
    public Sprite[] azul;
    int contador = 0;
    public bool cr_azul, cr_vermelho, cr_verde, cr_roxo;

    private void Start()
    {
        StartCoroutine("trocaazul");
        sprite = GetComponent<SpriteRenderer>();
    }

    public void troca_verde()
    {
        StartCoroutine("trocaverde");
    }

    public void troca_vermelho()
    {
        StartCoroutine("trocavermelho");
    }

    public void troca_azul()
    {

        StartCoroutine("trocaazul");
              
    }

    public void troca_roxo()
    {
        sprite.sprite = verde[0];
    }

    IEnumerator trocaverde()
    {

        cr_verde = true;
        contador = 0;

        while (contador < 17)
        {
            yield return new WaitForSeconds(0.1f);
            sprite.sprite = verde[contador];
            contador++;
            if (contador == 17)
            {
                contador = 0;
            }
            if (cr_vermelho || cr_roxo || cr_azul)
            {
                cr_verde = false;
                break;
            }

        }

    }



    IEnumerator trocaazul()
    {

        cr_azul = true;
        contador = 0;

        while ( contador < 17)
        {
            yield return new WaitForSeconds(0.1f);
            sprite.sprite = azul[contador];
            contador++;
            if ( contador == 17)
            {
                contador = 0;
            }
            if (cr_vermelho || cr_roxo || cr_verde)
            {
                cr_azul = false;
                break;
            }

        }

    }

    IEnumerator trocavermelho()
    {

        cr_vermelho = true;
        contador = 0;

        while (contador < 17)
        {
            yield return new WaitForSeconds(0.1f);
            sprite.sprite = vermelho[contador];
            contador++;
            if (contador == 17)
            {
                contador = 0;
            }
            if (cr_verde || cr_azul || cr_roxo)
            {
                cr_vermelho = false;
                break;
            }
        }

    }
}
