﻿using UnityEngine;

public interface IWeapon {
    void StartAim( Vector3 pos );
    void EndAim();
    void MoveAim( Vector3 pos );
    void KeepStartAim(Vector3 pos );
}
