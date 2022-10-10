using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CreateAssetMenu(menuName ="Assets/GameMode/ColleCtCoins", fileName = "CollectCoinsGameMode")]
public class CollectCoinsGameMode : ScriptableObject, IGameMode<int>
{
    public int coinsToWin;
    public GameState gameState;
    
    
    public void UpdateWinState(int value)
    {
        
    }
}
