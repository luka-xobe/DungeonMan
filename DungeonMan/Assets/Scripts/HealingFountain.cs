using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealingFountain : Collidable
{
        public int healingAmount = 1;
        
        private float healColldown = 1.0f;
        private float lastheal;

    protected override void OnCollide(Collider2D coll)
    {
        if (coll.name != "Player")
        {
            return;
        }

        if (Time.time - lastheal > healColldown)
        {
            lastheal = Time.time;
            GameManager.instance.player.Heal(healingAmount);
        }
    }







}
