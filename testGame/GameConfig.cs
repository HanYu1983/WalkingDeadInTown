﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class GameConfig
{
    public static float MoveSpeed = 400.0f;
    public static float DodgeSpeed = 14000.0f;
    public static int LongMoveDistance = 200;
    public static float AimOffsetY = 0.0f;

    public static List<object[]> WeaponConfig = new List<object[]>()
    {
        /* 0_name, 1_age, 2_size, 3_dragable, 4_count, 5_offset, 6_expand_speed, 7_delay, 8_startSize, 9_clearWhenRelease, 10_auto, 11_shootingTime, 11_using in test */
        new object[] { "步槍(半自動)", 10, .6f, false, 1, 30.0f, 0.5f, false, 0.0f, false, false, 5, false },
        new object[] { "高性能狙擊槍", 60, 1.0f, false, 1, 0.0f, 0.1f, false, 1.0f, true, false, 0, false },
        new object[] { "雙管散彈槍", 6, 1.0f, false, 10, 20.0f, 1.0f, false, 0.0f, false, false, 0, false },
        new object[] { "智慧型狙擊槍", 300, 1.0f, true, 1, 0.0f, 0.2f, true, .5f, true, false, 0, false },
        new object[] { "雷射加農砲", 300, 1.0f, true, 1, 0.0f, 0.1f, true, 0.0f, true, false, 0, false },
        new object[] { "砍刀:半自動", 10, 1.0f, false, 1, 0.0f, 0.03f, false, .7f, true, false, 0, true },
        new object[] { "步槍:全自動", 6, 1.0f, false, 1, 30.0f, 0.2f, false, 0.0f, false, true, 0, false },
        new object[] { "雷射機槍", 6, 1.0f, false, 1, 10.0f, 0.2f, false, 0.0f, false, true, 0, false },
        new object[] { "衝鋒槍", 6, 1.0f, false, 1, 15.0f, 0.2f, false, 0.0f, false, true, 0, false },
        new object[] { "步槍:全自動", 6, .6f, false, 1, 30.0f, 0.2f, false, 0.0f, false, true, 0, false }
    };
}