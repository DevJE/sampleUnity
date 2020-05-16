using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface MoveInterface
{
    void rightKeycode(float move);
    void leftKeycode(float move);
    void upKeycode(float move);
    void downKeycode(float move);
    void isGround(Collision2D collision);
 
}
