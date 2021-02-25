using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piece : MonoBehaviour
{
    int[] pos = new int[2];

    bool side;
    //Dark or Light side
    /* 0 == Light
     * 1 == Dark
     * */
    public int[] GetPos()
    {
        return pos;
    }

    public void SetPosX(int x)
    {
        if (x >= 0 && x < 8)
        {
            pos[0] = x;
        }
    }

    public void SetPosY(int y)
    {
        if (y >= 0 && y < 8)
        {
            pos[0] = y;
        }
    }

    public void SetPos(int x, int y)
    {
        if (x < 0 || x > 7) return;
        if (y < 0 || y > 7) return;

        pos[0] = x;
        pos[1] = y;
    }

    public bool GetSide() 
    {
        return side;
    }

    public void SetSide(bool newSide)
    {
        side = newSide;
    }
}