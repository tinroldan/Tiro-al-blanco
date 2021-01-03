using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    [SerializeField] GameObject dianaPrefab;
    [SerializeField] GameObject pantallaInicio,pantallaFinal;
    [SerializeField] float xMax,xMin,yMax,yMin,zPosition;
    [SerializeField] Text textPoints,textTime,textPointsEnd;

    public bool start;

    int points;
    float timeGame;
    float timeSpawn;
    void Start()
    {
        start=false;
        timeGame=30;
        pantallaInicio.SetActive(true);
        pantallaFinal.SetActive(false);

        Time.timeScale=0;
    }

    void Update()
    {
        textTime.text="Tiempo: " + timeGame.ToString("f0");
        textPoints.text="Puntaje: " + points.ToString();
        textPointsEnd.text="Puntaje: " + points.ToString();


        if(start==true)
        {

            if(timeGame>0)
        {
            if(timeSpawn>0)
        {
            timeSpawn-=Time.deltaTime;
        }
        if(timeSpawn<=0)
        {
            Instantiate(dianaPrefab,GetRandomPosition(),dianaPrefab.transform.rotation);
            timeSpawn=2;
        }
        
        timeGame-=Time.deltaTime;
        }
        else if(timeGame<=0)
        {
            start=false;
            pantallaFinal.SetActive(true);
            Time.timeScale=0;
        }


        }


        


        


        
    }

    Vector3 GetRandomPosition()
    {
        Vector3 spawnPos;


        spawnPos = new Vector3(Random.Range(xMin, xMax), Random.Range(yMin, yMax),zPosition);

        return spawnPos;
    }

    public void SetPoints(int value)
    {
        points+=value;
    }

    public void Empezar()
    {
        Time.timeScale=1;
        pantallaInicio.SetActive(false);
        start=true;
    }

    public void Restart()
    {
        SceneManager.LoadScene("Main");
    }
}
