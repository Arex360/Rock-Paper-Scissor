using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public List<Options> possibleOutcomes;
    public Options predict(Options playerChoice)
    {
        Options predictOption = possibleOutcomes[Random.Range(0, possibleOutcomes.Count)];
        while(predictOption == playerChoice)
        {
            bool draw = Random.value > 0.8f ? true : false;
            if (!draw)
            {
                predictOption = possibleOutcomes[Random.Range(0, possibleOutcomes.Count)];
            }
            else
            {
                break;
            }
        }
        return predictOption;
    }
}
