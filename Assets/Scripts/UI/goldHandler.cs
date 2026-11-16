using TMPro;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goldHandler : MonoBehaviour
{

		[SerializeField] private TMP_Text gold;
		[SerializeField] private goldSystem goldSystemRef;



    // Start is called before the first frame update
    void Start()
    {
    	updateGoldAmount(goldSystemRef.getCurrentGold()
    	);
        
    }

    	void updateGoldAmount(int currentGold)
		{
    		
    		gold.text =  currentGold + " Pesos";

		}

		void OnEnable()
    	{
    		goldSystemRef.onGoldChanged += updateGoldAmount;
    	}

		void OnDisable()
    	{
    		goldSystemRef.onGoldChanged  -= updateGoldAmount;
    	}


}
