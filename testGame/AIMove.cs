﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class AIMove : AIBasic
{
    public override void Update()
    {
        Vector3 targetPos = PlayerController.Position;
        if(ViewController.Player != null)
        {
            targetPos += GetPlayerMoveTarget(PlayerController, ViewController.Player, 100, TrackAndKeepMethod);

            List<PlayerController> mates = ViewController.Enemys;
            foreach (PlayerController m in mates)
            {
                if (PlayerController != m)
                {
                    targetPos += GetPlayerMoveTarget(PlayerController, m, 60, KeepMethod);
                }
            }
            PlayerController.SetPlayerPosition(targetPos);
        }
    }

    delegate bool TrackMethod(Vector3 diff, float distance);

    bool TrackAndKeepMethod(Vector3 diff, float distance)
    {
        return diff.magnitude > distance || diff.magnitude < distance - 10;
    }

    bool KeepMethod(Vector3 diff, float distance)
    {
        return diff.magnitude < distance - 10;
    }

    Vector3 GetPlayerMoveTarget(PlayerController follower, PlayerController hoster, float distance, TrackMethod method)
    {
        Vector3 diff = hoster.Position - follower.Position;
        Vector3 retOffset = new Vector3();
        if (method(diff, distance))
        {
            Vector3 dir = diff.normalized;
            Vector3 targetPos = hoster.Position + -dir * distance;
            retOffset = targetPos - follower.Position;
        }
        return retOffset;
    }
}
