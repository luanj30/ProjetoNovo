using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEditor;
using UnityEngine;

[CreateAssetMenu(menuName ="Assets/GameMode/ColleCtCoins", fileName = "CollectCoinsGameMode")]
public class CollectCoinsGameMode : GameModeso
{
    public int coinsToWin;

    public float timeTowin;
    
    public override void UpdateGameState([Optional] int intValue, [Optional] float floatValue, [Optional] bool boolValue)
    {
        if (intValue >= coinsToWin) GameState = GameState.Victory;
        if (floatValue >= timeTowin) GameState = GameState.GameOver;
    }
}
