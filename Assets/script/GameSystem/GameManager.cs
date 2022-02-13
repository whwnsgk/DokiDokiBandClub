using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int LovePoint = 0;
    public static int MiniGamePoint = 0;

    public static int MiniGamePointEd = MiniGamePoint / 30;
    public static int EdPoint = (LovePoint + MiniGamePointEd );

}
