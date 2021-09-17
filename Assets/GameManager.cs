using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    [SerializeField] private EnemyAI enemyAI;
    [SerializeField] private Options currentChoice;

    [SerializeField] private PlayerController player;
    [SerializeField] private EnemyController enemy;


    [SerializeField] private TextMeshProUGUI status;
    [SerializeField] private TextMeshProUGUI scoreText;
    public int Score; 
    [Header("Debug")]
    [SerializeField] private Options EnemyChoice;
    private void Start()
    {
        Score = 0;
        enemyAI = this.GetComponent<EnemyAI>();
        player = GameObject.FindObjectOfType<PlayerController>();
        enemy = GameObject.FindObjectOfType<EnemyController>();
    }
    private void Update()
    {
        scoreText.text = this.Score.ToString();
    }
    public void OnPaperClick()
    {
        currentChoice = Options.Paper;
        Options enemyChoice = enemyAI.predict(currentChoice);
        if(enemyChoice == Options.Rock)
        {
            Score++;
            status.text = "You win";
            print("You win");
        }
        else if(enemyChoice == currentChoice)
        {
            print("Match draw");
            status.text = "Match Draw";
        }
        else
        {
            print("You lose");
            status.text = "You lose";
        }
        EnemyChoice = enemyChoice;
        this.SetEnemySprite();
        this.SetPlayerSprite();
    }
    public void OnScissorClick()
    {
        currentChoice = Options.Scissor;
        Options enemyChoice = enemyAI.predict(currentChoice);
        EnemyChoice = enemyChoice;
        if (enemyChoice == Options.Paper)
        {
            Score++;
            status.text = "You win";
            print("You win");
        }
        else if (enemyChoice == currentChoice)
        {
            print("Match draw");
            status.text = "Match Draw";
        }
        else
        {
            print("You lose");
            status.text = "You lose";
        }
        this.SetEnemySprite();
        this.SetPlayerSprite();
    }
    public void OnRockClick()
    {
        currentChoice = Options.Rock;
        Options enemyChoice = enemyAI.predict(currentChoice);
        EnemyChoice = enemyChoice;
        if (enemyChoice == Options.Scissor)
        {
            Score++;
            status.text = "You win";
            print("You win");
        }
        else if (enemyChoice == currentChoice)
        {
            print("Match draw");
            status.text = "Match Draw";
        }
        else
        {
            print("You lose");
            status.text = "You lose";
        }
        this.SetEnemySprite();
        this.SetPlayerSprite();
    }
    private void SetEnemySprite()
    {
        enemy.currentOption = EnemyChoice;
        enemy.Setsprite();
    }
    private void SetPlayerSprite()
    {
        player.currentOption = currentChoice;
        player.Setsprite();
    }
}
