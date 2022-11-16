using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState {FreeRoam}

public class GameController : MonoBehaviour
{

    [SerializeField] PlayerController playerController;
    GameState state;

    private void Start()
    {
        //Dito initiate yung free roam state
        state = GameState.FreeRoam;
    }

    private void Update()
    {
        if(state == GameState.FreeRoam)
        {
            playerController.HandleUpdate();
        }else{

        }

    }
}
