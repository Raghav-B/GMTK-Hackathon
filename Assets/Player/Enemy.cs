﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character {


    public void damagePlayer(int damage) {

        bool isPlayerAlive = Player.Instance.takeDamage(damage);
        if (!isPlayerAlive) {
            Player.Instance.die();
        }
    }
}
