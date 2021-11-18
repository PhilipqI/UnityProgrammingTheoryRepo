using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class LifeManager : MonoBehaviour
{
    [SerializeField] private GameObject heartsPrefab;
    [SerializeField] private int m_lifes = 3;

    //Offset to next heart
    private float moveRightOffset = 1.2f;
    private List<GameObject> heartsGameObjects;
    [SerializeField] private Vector3 position = new Vector3(-9.5f, 6, -5);
    private GameManager gameManager;

    //ENCAPSULATION
    public int Lifes
    {
        get
        {
            return m_lifes;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.FindObjectOfType<GameManager>();
        heartsGameObjects = new List<GameObject>();

        for(int index = 0; index < m_lifes; index++)
        {
            Vector3 spawnPos = position;
            spawnPos.x = spawnPos.x + (moveRightOffset * index);

            GameObject heartsGameObject = Instantiate(heartsPrefab, spawnPos, heartsPrefab.transform.rotation);
            heartsGameObject.transform.SetParent(gameObject.transform, false);
            heartsGameObjects.Add(heartsGameObject);
        }
    }

    public void ReduceLives()
    {
        m_lifes--;
        ReduceLivesUI();

        if(m_lifes == 0)
        {
            gameManager.GameOver();
        }
    }

    private void ReduceLivesUI()
    {
        int index = heartsGameObjects.Count - 1;
        GameObject heartToRemove = heartsGameObjects[index];
        heartsGameObjects.RemoveAt(index);

        Destroy(heartToRemove);
    }    
}
