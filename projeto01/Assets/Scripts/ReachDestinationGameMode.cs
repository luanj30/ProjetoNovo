using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
[CreateAssetMenu(menuName ="Assets/GameMode/ReachDestinationGameMode", fileName = "ReachDestinationGameModeso")]
public class ReachDestinationGameMode : GameModeso
{
    public bool userTimer;
    public float timeToLose;
    public override void UpdateGameState([Optional] int intValue, [Optional] float floatValue, [Optional] bool boolValue)
    {
        if (boolValue) gameState = GameState.Victory;
        if (userTimer && floatValue >= timeToLose) gameState = GameState.GameOver;
    }
}
