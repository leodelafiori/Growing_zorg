using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawna_bala : MonoBehaviour {
   
    // Criando array de game object
    public GameObject bala;


    //Objeto para instanciar as prefabs
    public GameObject go;

    private int contador = 0;


    // Use this for initialization
    void Start()
    {

        StartCoroutine("Spawnar");


    }

    // Update is called once per frame
    public void Update()
    {


    }

    public void Spawna()
    {
        go = Instantiate(bala) as GameObject;
        
        // Setando o spawna_bala como parente
        go.transform.SetParent(transform);

        //Colocando o prefab no lugar certo
        go.transform.position = transform.position;

    }

    IEnumerator Spawnar()
    {
        while (contador <= 1)
        {
            float tempo_aleatorio = Random.Range(2, 4);
            yield return new WaitForSeconds(tempo_aleatorio);
            Spawna();
        }

    }

    public int RandomPrefab()
    {
        int randomIndex;

        randomIndex = Random.Range(0, 1);
        return randomIndex;
    }
}
