using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public float totalDinero = 2000;
    public float totalSalud = 100;
    public float totalComida = 100;
    public LevelType levelType;
    public bool isFinalGame = false;
    private void Awake()
    {

        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }




    // Start is called before the first frame update
    void Start()
    {
        LevelType level = levelType;
        string levelstring = level.ToString();
        Debug.Log(levelstring);
    }

    // Update is called once per frame
    void Update()
    {
        if (GetTotalDinero() <= 0)
        {
            isFinalGame = true;
        }
    }

    public float GetTotalComida()
    {
        return totalComida;
    }
    public void SetTotalComida(float comida)
    {
        totalComida += comida;
    }

    public float GetTotalSalud()
    {
        return totalSalud;
    }
    public void SetTotalSalud(float salud)
    {
        totalSalud += salud;
    }
    public float GetTotalDinero()
    {
        return totalDinero;
    }
    public void SetTotalDinero(float dinero)
    {
        totalDinero += dinero;
    }
}
