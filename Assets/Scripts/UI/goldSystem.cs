using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class goldSystem : MonoBehaviour
{

	[SerializeField] private int currentGold = 25;

    public event Action<int> onGoldChanged;

   public int getCurrentGold(){
    
   			 return currentGold;
	
			}

public bool changeGold(int amount){
    
	if (currentGold + amount < 0)
	{
    return false;
	}

	currentGold += amount;

	onGoldChanged?.Invoke(currentGold);

	return true;
	}

public void sellLoot(){                                 //fake sell item
    
	int randomGold = UnityEngine.Random.Range(1, 8);
		changeGold(randomGold);


	}

}