using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    GameObject[] arrayPlayers;
    public GameObject player1;
    public GameObject player2;
    public GameObject player3;
    public GameObject player4;
    GameObject aux;

    private void Start()
    {
        arrayPlayers = new GameObject[4] { player1, player2, player3, player4 };
        aux = arrayPlayers[0];
        
    }

    private void Update()
    {

        

        if (Input.GetKeyDown(KeyCode.Q))
        {

        }
    }

    private void OnEnable()
    {
        
    }
    private void OnDisable()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {

            aux.SetActive(false);

        }
    }



}
