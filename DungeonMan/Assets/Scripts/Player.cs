using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Mover
{

    private SpriteRenderer spriteRenderer;

    protected override void Start()
    {
        base.Start();
        spriteRenderer = GetComponent<SpriteRenderer>();

        
    }

    protected override void RecieveDamage(Damage dmg)
    {
        base.RecieveDamage(dmg);
        GameManager.instance.OnHitpointChange();
    }


    private void FixedUpdate()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        UpdateMotor(new Vector3(x, y, 0));
    }


    public void SwapSprite(int skinid)
    {
        GetComponent<SpriteRenderer>().sprite = GameManager.instance.playerSprites[skinid];
    }

        
    public void OnLevelUp()
    {
        maxHitpoint++;
        hitpoint = maxHitpoint;
        //GameManager.instance.ShowText(" LEVEL UP!" , 35, Color.white, transform.position, Vector3.up * 35, 1.5f);
    }
    public void SetLevel(int level)
    {
        for (int i = 0; i < 0; i++)
            OnLevelUp();
    }


    public void Heal(int healingAmount)
    {

        if (hitpoint == maxHitpoint)
        {

            return;
        }

        hitpoint += healingAmount;
        if (hitpoint > maxHitpoint)
            hitpoint = maxHitpoint;
        GameManager.instance.ShowText("+" + healingAmount.ToString() + "hp", 25, Color.green, transform.position, Vector3.up * 30, 1.0f);
        GameManager.instance.OnHitpointChange();
    }


   
}


