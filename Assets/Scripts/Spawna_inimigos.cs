using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawna_inimigos : MonoBehaviour {

    // Criando array de game object
    public GameObject[] prefabs;
    
    //Variavel pra contar e spawnar inimigos infinitamente no update
    public int contador = 0;

    //Objeto para instanciar as prefabs
    public GameObject go;


    // Use this for initialization
    void Start() {

        StartCoroutine("Spawnar");


    }

    // Update is called once per frame
    public void Update() {
        

    }

    public void Spawna()
    {
        int inimigo_aleatorio = Random.Range(0, 2);

        if (inimigo_aleatorio == 1)
        {

            go = Instantiate(prefabs[inimigo_aleatorio]) as GameObject;
            //go = Instantiate(prefabs[RandomPrefab()]) as GameObject;
            // Setando o spawna_tiles como parente
            go.transform.SetParent(transform);

            //Colocando o prefab no lugar certo
            go.transform.position = new Vector3(7.7f, 0.5f, 0);
            

        }
        else
        {
            go = Instantiate(prefabs[inimigo_aleatorio]) as GameObject;
            //go = Instantiate(prefabs[RandomPrefab()]) as GameObject;
            // Setando o spawna_tiles como parente
            go.transform.SetParent(transform);

            //Colocando o prefab no lugar certo
            go.transform.position = gameObject.transform.position;
        }
    }

    IEnumerator Spawnar()
    {
        while(contador <= 1)
        {
            float tempo_aleatorio = Random.Range(1.5f, 3);
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
