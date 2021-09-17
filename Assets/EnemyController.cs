using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : Controller
{
    public Dictionary<Options, int> getImage;

    public void SetInstance()
    {
        getImage.Add(Options.Paper, 0);
        getImage.Add(Options.Rock, 1);
        getImage.Add(Options.Scissor, 2);
        print("indexes added");
    }
    void Start()
    {
        getImage = new Dictionary<Options, int>();
        this.SetInstance();
        this.sprite = this.GetComponent<SpriteRenderer>();
        // Update is called once per frame
        
    }
    public void Setsprite()
    {
        this.sprite.sprite = this.image[getImage[currentOption]];
    }
}

