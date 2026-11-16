using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class xpSystem : MonoBehaviour
{

    [SerializeField] private int currentXp = 25;
    [SerializeField] private int requiredXp = 100;
	[SerializeField] private int currentLevel = 1;

    public event Action<int, int, int> onXpChanged;


    public int getCurrentXp(){
	
			return currentXp;
    
    		}

    public int getRequiredXp(){
	
			return requiredXp;
    
    		}

    public int getCurrentLevel(){
    
   			 return currentLevel;
	
			}


	public void addXp(int amount)
	{
    
	 	currentXp += amount;


    //Tant que l'XP atteint le seuil

		while (currentXp >= requiredXp) {

		currentXp -= requiredXp;				//Conserver le surplus

		currentLevel +=  1 ;					//Augmenter le niveau

		requiredXp += 100 ;						//Calculer le prochain seuil

		}



	 onXpChanged?.Invoke(currentXp,requiredXp,currentLevel);

	}



}
