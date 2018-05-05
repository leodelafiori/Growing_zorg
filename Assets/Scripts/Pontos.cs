using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Pontos : MonoBehaviour {

    public TextMeshProUGUI pontuacao;
    public int ponto = 0;

	// Use this for initialization
	void Start () {


        Time.timeScale = 1;
        pontuacao.text = ponto.ToString();
        StartCoroutine("ponto_segundo");
    }

    private void FixedUpdate()
    {

    }

    IEnumerator ponto_segundo()
    {
        int num = 0;
        while (num < 1)
        {
            yield return new WaitForSeconds(1);
            ponto++;
            pontuacao.text = ponto.ToString();
        }
    }
}
