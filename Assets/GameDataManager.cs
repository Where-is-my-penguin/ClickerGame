using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDataManager : MonoBehaviour
{
    [System.Serializable]
    public class GameData
    {
        // –есурсы
        public int ветки;
        public int камни;
        public int солома;
        public int брЄвна;
        public int топоры;
        public int лопаты;


        // ƒеревн€
        public int жители;
        public int свободныећеста;
        public int свободные–абочиећеста;
        public int рабочиећестаЋесопилки;
        public int рабочиећеста«емлекопа;
        public int зан€тыећестаЋесопилки;
        public int зан€тыећеста«емлекопа;
        public int жителиЌа–аботе;


        // ѕрогресс задани€
        public int этап«адани€;
    }
}
