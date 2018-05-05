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

        
        int inimigo_aleatorio = Random.Range(0, 1);

        StartCoroutine("Spawnar");


    }

    // Update is called once per frame
    public void Update() {
        

    }

    public void Spawna()
    {

        go = Instantiate(prefabs[RandomPrefab()]) as GameObject;
        // Setando o spawna_tiles como parente
        go.transform.SetParent(transform);

        //Colocando o prefab no lugar certo
        go.transform.position = gameObject.transform.position;

    }

    IEnumerator Spawnar()
    {
        while(contador <= 1)
        {
            int tempo_aleatorio = Random.Range(1, 3);
            yield return new WaitForSeconds(tempo_aleatorio);
            Spawna();
        }

    }

    public int RandomPrefab()
    {
        int randomIndex;

        randomIndex = Random.Range(0, 0);
        return randomIndex;
    }




}
