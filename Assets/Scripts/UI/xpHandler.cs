using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class xpHandler : MonoBehaviour
{


	[SerializeField] private Image fillImage;
	[SerializeField] private xpSystem xpSystemRef;
	[SerializeField] private TMP_Text currentLevelDisplay;


    	// Start is called before the first frame update
    	void Start()
    	{
    updateXpBar(
        xpSystemRef.getCurrentXp(),
        xpSystemRef.getRequiredXp(),
        xpSystemRef.getCurrentLevel()
	    );

    	}


    	void updateXpBar(int currentXp, int requiredXp, int currentLevel)
		{
    		fillImage.fillAmount = (float)currentXp/requiredXp ;  // Calcul du Fill Amount
    		
    		currentLevelDisplay.text = "Lvl " + currentLevel;

		}



		void OnEnable()
    	{
    		xpSystemRef.onXpChanged += updateXpBar;
    	}

		void OnDisable()
    	{
    		xpSystemRef.onXpChanged -= updateXpBar;
    	}




}
