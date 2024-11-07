/****************************************************************************************
 * Copyright: Jeff Moreau
 * Script: EnemySO.cs
 * Date Created: October 20, 2023
 * Created By: Jeff Moreau
 * Used On:
 * Description:
 ****************************************************************************************
 * Modified By: Jeff Moreau
 * Date Last Modified: November 5, 2024
 ****************************************************************************************
 * TODO:
 * Known Bugs:
 ****************************************************************************************/

using UnityEngine;

namespace TrenchWars.Data
{
    [CreateAssetMenu(fileName = "EnemyData", menuName = "Data/New EnemyData")]
    public class EnemyData : EntityData
    {
        //FIELDS
        #region Private Serialized Fields: For Inspector Editable Values

        [SerializeField] private float _maxShield = 0.0f;
        [SerializeField] private float _shootingSpeed = 0.0f;

        #endregion

        //PROPERTIES
        #region Public Properties: For Accessing Class Fields

        public float GetMaxShield => _maxShield;
        public float GetShootingSpeed => _shootingSpeed;

        #endregion
    }
}