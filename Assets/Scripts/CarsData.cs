using System;
using System.Collections.Generic;
using UnityEngine;

namespace DataBases
{
    [CreateAssetMenu(fileName = "CarsData", menuName = "Cars Data", order = 51)]
    public class CarsData : ScriptableObject
    {
        [SerializeField] private List<CarInfo> _carInfoList;

        public CarInfo GetCarInfoByType(CarType type)
        {
            foreach (CarInfo info in _carInfoList)
            {
                if (info.Type == type)
                {
                    return info;
                }
            }
            
            return default;
        }
    }

    [Serializable]
    public class CarInfo
    {
        [SerializeField] private CarType type;
        [SerializeField] private GameObject carPref;
        public CarType Type => type;
        public GameObject CarPref => carPref;
    }

    public enum CarType
    {
        BMW,
        Mersedes
    }
}
