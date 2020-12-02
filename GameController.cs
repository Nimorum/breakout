using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController instance;

    List<GameObject> gameBricks = new List<GameObject>();
    [SerializeField]
    GameObject[] bricksPrefab;
    [SerializeField]
    Color[] levelColors;
    int level = 1;
    int playerLifes=3;

    int points = 0;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            GameObject.Destroy(this.gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        CreateBricks();
    }

    private void CreateBricks()
    {
        float posX = -20;
        float posY = 15;

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                int roll = (int)Random.Range(0, 4);

                switch (roll)
                {
                    case 0:
                        break;
                    case 1:
                        gameBricks.Add(GameObject.Instantiate(bricksPrefab[0], new Vector3(posX, posY, 0), Quaternion.identity));
                        break;
                    case 2:
                        gameBricks.Add(GameObject.Instantiate(bricksPrefab[1], new Vector3(posX, posY, 0), Quaternion.identity));
                        break;
                    case 3:
                        gameBricks.Add(GameObject.Instantiate(bricksPrefab[2], new Vector3(posX, posY, 0), Quaternion.identity));
                        break;
                    default:
                        break;
                }
                posX += 4;
            }
            posX = -20;
            posY -= 1.5f;
        }
    }

    public void AddPoints(int _points)
    {
        points += _points*level;
    }

    public void RemoveBrickFromList(GameObject brick)
    {
        gameBricks.Remove(brick);
        if (gameBricks.Count <= 0)
        {
            CreateBricks();
        }
    }

    public void PlayerDie()
    {
        GameObject.FindObjectOfType<PlayerController>().SetBallInPlay(false);
        GameObject.FindObjectOfType<ball>().GetComponent<ParticleSystem>().Clear();
    }
}
