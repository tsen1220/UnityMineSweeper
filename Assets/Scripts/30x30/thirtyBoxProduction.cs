﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thirtyBoxProduction : MonoBehaviour
{
    [SerializeField]
    private GameObject GameBox;

    public static int Horizon = 30;
    public static int Vertical = 30;

    public bool[,] Grid = new bool[Horizon, Vertical];

    private void Awake()
    {
        createBoard();
    }

    private void createBoard()
    {
        int OriginYpos = -8;
        for (int i = 0; i < Horizon; i++)
        {
            for (int j = 0; j < Vertical; j++)
            {
                bool MineExisted = Random.value < 0.1;

                GameBox.GetComponent<thirtyBoxScript>().mine = MineExisted;

                Instantiate(GameBox, transform.position, Quaternion.identity);

               Grid[i, j] = GameBox.GetComponent<thirtyBoxScript>().mine;

                transform.position += new Vector3(0, 0.65f, 0);
            }
            transform.position = new Vector3(transform.position.x, OriginYpos, 0);
            transform.position += new Vector3(0.65f, 0, 0);
        }
    }
}
