using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HUDController : MonoBehaviour
{
    public Image healthBar;
    public Image fuelBar;
    public Text capacityText;

    private float maxHealth = 1;
    private float minHealth = 0;
    public float currentHealth;

    private float maxFuel = 1;
    private float minFuel = 0;
    public float currentFuel;
    public float fuelLossRate;

    private int maxCapacity = 100;
    private float minCapacity = 0;
    public int currentCapacity;


    private void Start()
    {
        currentHealth = 1;
        currentFuel = 1;
        currentCapacity = 0;
    }

    private void Update()
    {
        healthBar.fillAmount = currentHealth;
        fuelBar.fillAmount = currentFuel;
        capacityText.text = string.Format("Capacity: {0}/{1}", currentCapacity, maxCapacity);
    }

}
