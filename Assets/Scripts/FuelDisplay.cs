using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FuelDisplay : MonoBehaviour
{
    public GameObject fuelCell;
    public int fuelNeeded = 15;
    public Color fuelCellEmptyColor;
    public Color fuelCellFilledColor;

    private GameObject[] fuelCells;
    private int fuelLevel = 0;

    void Start()
    {
        PopulateFuel();
    }

    private void PopulateFuel()
    {
        fuelCells = new GameObject[fuelNeeded];
        for(int i = 0; i < fuelNeeded; i++)
        {
            fuelCells[i] = Instantiate(fuelCell, transform);
            fuelCells[i].GetComponent<Image>().color = fuelCellEmptyColor;
        }
    }

    public void AddFuel()
    {
        if(fuelLevel < fuelNeeded - 1)
        {
            fuelCells[fuelLevel].GetComponent<Image>().color = fuelCellFilledColor;
            fuelLevel++;
        }
        else
        {
            EraseFuel();
        }
    }
    private void EraseFuel()
    {
        for(int i = 0; i < fuelNeeded; i++)
        {
            fuelCells[i].GetComponent<Image>().color = fuelCellEmptyColor;
            fuelLevel = 0;
        }
    }
}
