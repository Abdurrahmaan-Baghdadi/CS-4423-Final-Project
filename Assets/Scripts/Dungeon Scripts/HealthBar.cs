using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    public GameObject healthPointPreFab;

    //public int maxNumber = 3;
    public Color filledHPColor = Color.red;
    //public int currentNumber = 3;
    public Color emptyHPColor = Color.grey;

    public List<Image> existingHealthPoints;
    public List<GameObject> existingHealthObjects;

    public static HealthBar healthBar = null;

    GameObject curObject;
    public int defaultMax = 1;

    void Awake()
    {
        if(healthBar == null)
        {
            healthBar = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    void Start()
    {
        SetMaxHP(defaultMax);
        SetHealth(defaultMax);

        
    }

    public void SetMaxHP(int maxNumber)
    {
        for(int i = 0; i<existingHealthObjects.Count; i++)
        {
            Destroy(existingHealthObjects[i]);
        }
        existingHealthPoints = new List<Image>();
        for(int i = 0; i<maxNumber; i++)
        {
            curObject = (GameObject) Instantiate(healthPointPreFab, this.transform);
            existingHealthPoints.Add(curObject.GetComponent<Image>());
            existingHealthObjects.Add(curObject);
        }
    }

    public void SetHealth(int value)
    {
        for(int i = 0; i < value; i++)
        {
            existingHealthPoints[i].color = filledHPColor;
        }
        for(int i = value; i<existingHealthPoints.Count; i++)
        {
            existingHealthPoints[i].color = emptyHPColor;
        }
    }
    

}
